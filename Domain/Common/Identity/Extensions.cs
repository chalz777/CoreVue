using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Authentication;

namespace Web.Security.Identity
{
    public static class Extensions
    {

        public static AuthenticationBuilder AddDrtAuthentication(this AuthenticationBuilder builder)
        {
            return builder.AddScheme<AuthenticationOptions, SSRNMAuthenticationHandler>(AuthenticationDefaults.AuthenticationScheme, "SSRNM Application Authentication", o => { });
        }
    }
}
