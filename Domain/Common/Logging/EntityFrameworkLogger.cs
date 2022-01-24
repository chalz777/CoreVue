using System;
using System.Collections;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Logging
{
    public class EntityFrameworkLogger<TDbContext, TLog> : ILogger
        where TLog : EntityFrameworkLog, new()
        where TDbContext : DbContext
    {
        const int _indentation = 2;
        readonly string _name;
        readonly Func<string, LogLevel, bool> _filter;
        IServiceProvider _services;

        public EntityFrameworkLogger(string name, Func<string, LogLevel, bool> filter, IServiceProvider serviceProvider)
        {
            _name = name;
            _filter = filter ?? GetFilter(serviceProvider.GetService<IOptions<EntityFrameworkLoggerOptions>>());
            _services = serviceProvider;
        }

        private Func<string, LogLevel, bool> GetFilter(IOptions<EntityFrameworkLoggerOptions> options)
        {
            if (options != null)
            {
                return ((category, level) => GetFilter(options.Value, category, level));
            }
            else
                return ((category, level) => true);
        }

        private bool GetFilter(EntityFrameworkLoggerOptions options, string category, LogLevel level)
        {
            if (options.Filters != null)
            {
                var filter = options.Filters.Keys.FirstOrDefault(p => category.StartsWith(p));
                if (filter != null)
                    return (int)options.Filters[filter] <= (int)level;
                else return true;
            }
            return true;
        }

        public void Log(LogLevel logLevel, int eventId, object state, Exception exception, Func<object, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
            }
            var message = string.Empty;
            var values = state as EntityFrameworkLog;
            if (formatter != null)
            {
                message = formatter(state, exception);
            }
            else if (values != null)
            {
                var builder = new StringBuilder();
                FormatLogValues(
                    builder,
                    values,
                    level: 1,
                    bullet: false);
                message = builder.ToString();
                if (exception != null)
                {
                    message += Environment.NewLine + exception;
                }
            }
            else
            {
                //message = LogFormatter.Formatter(state, exception);
            }
            if (string.IsNullOrEmpty(message))
            {
                return;
            }

            var log = new TLog
            {
                Message = Trim(message, EntityFrameworkLog.MaximumMessageLength),
                Date = DateTime.UtcNow,
                Level = logLevel.ToString(),
                Logger = _name,
                Thread = eventId.ToString()
            };

            if (exception != null)
                log.Exception = Trim(exception.ToString(), EntityFrameworkLog.MaximumExceptionLength);

            var httpContext = _services.GetRequiredService<IHttpContextAccessor>()?.HttpContext;

            if (httpContext != null)
            {
                log.Browser = httpContext.Request.Headers["User-Agent"];
                log.Username = httpContext.User.Identity.Name;
                try { log.HostAddress = httpContext.Connection.LocalIpAddress?.ToString(); }
                catch (ObjectDisposedException) { log.HostAddress = "Disposed"; }
                log.Url = httpContext.Request.Path;
            }

            var db = _services.GetRequiredService<TDbContext>();
            db.Set<TLog>().Add(log);

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }

        }

        private static string Trim(string value, int maximumLength)
        {
            return value.Length > maximumLength ? value.Substring(0, maximumLength) : value;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return _filter(_name, logLevel);
        }

        public IDisposable BeginScopeImpl(object state)
        {
            return new NoopDisposable();
        }

        private void FormatLogValues(StringBuilder builder, EntityFrameworkLog logValues, int level, bool bullet)
        {
            builder.Append(logValues.Date);
            builder.AppendLine();
            builder.Append(logValues.Thread);
            builder.AppendLine();
            builder.Append(logValues.Level);
            builder.AppendLine();
            builder.Append(logValues.Logger);
            builder.AppendLine();
            builder.Append(logValues.Message);
            builder.AppendLine();
            builder.Append(logValues.Exception);
            builder.AppendLine();
            builder.Append(logValues.HostAddress);
            builder.AppendLine();
            builder.Append(logValues.Username);
            builder.AppendLine();
            builder.Append(logValues.Browser);
            builder.AppendLine();
            builder.Append(logValues.Url);
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            throw new NotImplementedException();
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }

        private class NoopDisposable : IDisposable
        {
            public void Dispose()
            {
            }
        }
    }

}
