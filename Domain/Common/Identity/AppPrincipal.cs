using System.Security.Claims;
using KDT.Utilities.Claims;
using SSRNMFSSN.Data.Models;

namespace Web.Security.Identity
{
    public class AppPrincipal : ClaimsPrincipal
    {

        public AppPrincipal(User user)
        {
            if (user == null)
            {
                return;
            }
            var identity = new ClaimsIdentity("DRT");

            identity.AddClaim(new Claim(ClaimTypes.Name, user.Edipi, ClaimValueTypes.String));
            identity.AddClaim(new Claim(ClaimTypes.Email, user.Email, ClaimValueTypes.Email));
            identity.AddClaim(new Claim("DRT-UserId", user.UserId.ToString(), ClaimValueTypes.Integer, "DRT"));

                //Commented below line because we are not currently using user roles for the project. 
                //identity.AddClaim(new Claim(ClaimTypes.Role, role.Title, ClaimValueTypes.String));
                //We are also adding the role as a Json claim so we can verify roles for their command as well.
                identity.AddClaim(new JsonClaim<Roles>(user.Role));

            this.AddIdentity(identity);
        }

        public static implicit operator AppPrincipal(User user)
        {
            return new AppPrincipal(user);
        }

    }
}
