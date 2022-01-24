using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace EntityFramework.Logging
{
    public class EntityFrameworkLoggerOptions
    {
        public Dictionary<string, LogLevel> Filters { get; set; }
    }
}