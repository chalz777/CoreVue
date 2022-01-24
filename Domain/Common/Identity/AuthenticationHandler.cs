using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using System.Text.Encodings.Web;
using System.Linq;
//using KDT.EntityFramework.LinqExpander;
using SSRNMFSSN.Data.Models;
using Microsoft.Extensions.Internal;
using Microsoft.Owin.Security.Infrastructure;

namespace Web.Security.Identity
{
    public class SSRNMAuthenticationHandler : AuthenticationHandler<AuthenticationOptions>
    {

        private SSRNMFSSNContext Database { get; set; }

        public SSRNMAuthenticationHandler(IOptionsMonitor<AuthenticationOptions> options, ILoggerFactory logger, UrlEncoder encoder, Microsoft.AspNetCore.Authentication.ISystemClock clock, SSRNMFSSNContext context) : base(options, logger, encoder, clock)
        {
            Database = context;
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var edipi = Context.User.Claims.Where(c => c.Type == "edipi").FirstOrDefault()?.Value;
            //var user = Database.User.AsExpandable().Where(u => u.Edipi == edipi).FirstOrDefault();
            //if (user == null)
            //{
            //    return Task.FromResult(AuthenticateResult.Fail("No user found for edipi."));
            //}

            //var principal = new Principal(user);

            //var ticket = new AuthenticationTicket(principal, AuthenticationDefaults.AuthenticationScheme);
            //return Task.FromResult(AuthenticateResult.Success(ticket));
            return null;
        }
    }
}
