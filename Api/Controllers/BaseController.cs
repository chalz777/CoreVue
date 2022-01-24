using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SSRNMFSSN.Domain;
using System.Security.Claims;

namespace DRT.MVC.Api.Controllers
{
    [ApiController]

    public abstract class BaseController<TDto, TEntity> : ControllerBase where TDto : class where TEntity : class
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        protected ILogger _logger;
        protected IDomain<TDto, TEntity> _domain;
        protected UserDomain _userDomain;

        public BaseController(IHttpContextAccessor httpContextAccessor, ILogger<BaseController<TDto, TEntity>> logger, IDomain<TDto, TEntity> domain)
        {
            _logger = logger;
            _domain = domain;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        protected string GetUser()
        {
            return _httpContextAccessor.HttpContext.User.FindFirst("edipi").Value;//(UserDto)
        }

        /// <summary>
        /// The EDIPI of the current user based on provided client certificate.
        /// </summary>
        protected virtual string CurrentUserEdipi
        {
            get
            {
                if (User != null && User.Claims != null)
                {
                    var edipi = User.Claims.Where(c => c.Type == "edipi").FirstOrDefault()?.Value;
                    return edipi;
                }
                else
                {
                    _logger.LogWarning("CurrentUserEdipi was called but no authenticated identity was found.");
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Get the current claims principal.
        /// </summary>
        /// <returns></returns>
        protected ClaimsPrincipal GetClaimsPrincipal()
        {
            return HttpContext.User;
        }

        /// <summary>
        /// Get the current edipi of the user.
        /// </summary>
        /// <returns></returns>
        protected string GetCurrentUserEdipi()
        {
            return GetClaimsPrincipal().Claims
                .Where(c => c.Type.Equals("edipi"))
                .Select(c => c.Value)
                .SingleOrDefault();
        }

        /// <summary>
        /// Get the email of the current user.
        /// </summary>
        /// <returns></returns>
        protected string GetCurrentUserEmail()
        {
            return GetClaimsPrincipal().Claims
                .Where(c => c.Type.Equals(ClaimTypes.Email))
                .Select(c => c.Value)
                .SingleOrDefault();
        }

        // GET: api/Routes
        [HttpGet]
        public virtual async Task<IActionResult> Get()
        {
            if (CanGet())
            {
                ICollection<TDto> returnMe = _domain.GetAll();
                if (returnMe != null)
                {
                    return Ok(returnMe);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return Forbid();
            }
        }

        // GET: api/Routes/5
        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Get(int id)
        {
            if (CanGet())
            {
                var returnMe = _domain.Get(id);

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

        // PUT: api/Routes/5
        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Put(int id, TDto dto)
        {
            if (CanPut(id))
            {
                var result = _domain.Update(id, dto);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return Forbid();
                }
            }
            else
            {
                return Forbid();
            }
        }

        // POST: api/Routes
        [HttpPost]
        public virtual async Task<IActionResult> Post(TDto dto)
        {
            if (CanPost(dto))
            {
                return Ok(_domain.Create(dto));
            }
            else
            {
                return Forbid();
            }
        }

        // DELETE: api/Routes/5
        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            if (CanDelete(id))
            {
                _domain.Delete(id);
                return Ok();
            }
            else
            {
                return Forbid();
            }
        }

        private bool Exists(int id)
        {
            return _domain.Get(id) != null;
        }

        protected virtual bool CanPut(int id) { return false; }
        protected virtual bool CanGet() { return false; }
        protected virtual bool CanDelete(int id) { return false; }
        protected virtual bool CanPost(TDto dto) { return false; }

    }
}
