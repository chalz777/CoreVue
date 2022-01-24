using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SSRNMFSSN.Data.Models;
using SSRNMFSSN.Data.Models.DTO;
using SSRNMFSSN.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DRT.MVC.Api.Controllers
{
    [Route("api/[controller]")]
    public class UserController : BaseController<UserDto, User>
    {
        public UserController(IHttpContextAccessor httpContextAccessor, ILogger<UserController> logger, UserDomain domain) : base(httpContextAccessor, logger, domain)
        {
        }

        [HttpGet("Find/{query}")]
        public async Task<IActionResult> Find(string query)
        {
            if (CanGet())
            {
                var returnMe = ((UserDomain)_domain).GetUsersByName(query);

                if (returnMe == null)
                {
                    return NotFound();
                }

                return Ok(returnMe);
            }
            else
            {
                return Forbid();
            }
        }

        [HttpGet("IsAdmin")]
        public async Task<IActionResult> IsAdmin()
        {
            var returnMe = ((UserDomain)_domain).IsAdmin(GetCurrentUserEdipi());

            return Ok(returnMe);
        }

        [HttpGet("Current")]
        public async Task<IActionResult> Current()
        {
            var returnMe = ((UserDomain)_domain).GetUserByEDIPI(GetCurrentUserEdipi());

            return Ok(returnMe);
        }

        protected override bool CanPut(int id) { return ((UserDomain)_domain).IsAdmin(GetCurrentUserEdipi()); }
        protected override bool CanDelete(int id) { return ((UserDomain)_domain).IsAdmin(GetCurrentUserEdipi()); }
        protected override bool CanPost(UserDto dto) { return ((UserDomain)_domain).IsAdmin(GetCurrentUserEdipi()); }
        protected override bool CanGet() { return true; }

    }
}
