using System.IO;
using System.Threading.Tasks;
using SSRNMFSSN.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SSRNM.Global;
using SSRNMFSSN.Data.Models;
using SSRNMFSSN.Data.Models.DTO;
using SSRNMFSSN.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DRT.MVC.Api.Controllers
{
    [Route("api/[controller]")]
    public class ReportController : ControllerBase
    {
        private UserDomain _userDomain;
        private ReportDomain _reportDomain;
        SSRNMGlobal _globals;

        public ReportController(IOptions<SSRNMGlobal> globals, UserDomain userDomain, ReportDomain reportDomain)
        {
            var context = new SSRNMFSSNContext();
            _userDomain = userDomain;
            _reportDomain = reportDomain;
            _globals = globals.Value;
        }

        [HttpGet("Find/{query}")]
        public async Task<IActionResult> Find(string query)
        {
            if (CanGet())
            {
                var returnMe = _userDomain.GetUsersByName(query);

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

        /// <summary>
        /// Get the filename from the link and open in new tab.
        /// Pacific Fleet
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> SSRNMSCIURStaticDocument(string filename) //This menthod will open document when link is clicked.
        {
            string fileNameWithExt = filename + ".pdf";
            string folderpath = (_globals.FileFolder.ToString());
            string filepath = Path.Combine(folderpath, fileNameWithExt);
            filepath = Path.GetFullPath(filepath);

            if (!filepath.StartsWith(folderpath))
            {
                return Forbid();
            }
            return File(filepath, "application/pdf");
        }

        /// <summary>
        /// Get the filename from the link and open in new tab.
        /// Atlantic Fleet
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> SSRNMAUTECStaticDocument(string filename) //This method will open document when link is clicked.
        {
            string fileNameWithExt = filename + ".pdf";
            string folderpath = (_globals.FileFolder.ToString());
            string filepath = Path.Combine(folderpath, fileNameWithExt);
            filepath = Path.GetFullPath(filepath);

            if (!filepath.StartsWith(folderpath))
            {
                return Forbid();
            }
            return File(filepath, "application/pdf");
        }

        [HttpGet]
        [AllowAnonymous] 
        public async Task<IActionResult> SSRNMCriteriaPdf(string filename)
        {
            string fileNameWithExt = filename + ".pdf";
            string folderpath = (_globals.Pdf.ToString());
            string filepath = Path.Combine(folderpath, fileNameWithExt);
            filepath = Path.GetFullPath(filepath);

            if (!filepath.StartsWith(folderpath))
            {
                return Forbid();
            }
            return File(filepath, "application/pdf");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> SSRNMCriteriaExcel(string filename)
        {
            string fileNameWithExt = filename + ".xlsx";
            string folderpath = (_globals.Excel.ToString());
            string filepath = Path.Combine(folderpath, fileNameWithExt);
            // filepath = Path.GetFullPath(filepath);

            string contentType;
            new FileExtensionContentTypeProvider().TryGetContentType(fileNameWithExt, out contentType);

            if (!filepath.StartsWith(folderpath))
            {
                return Forbid();
            }
            return File(filepath, contentType, fileNameWithExt);
        }


        [HttpGet]
        [Route("PacificNonAsw")]
        public async Task<IActionResult> PacificNonAsw()
        {
            return Ok(_reportDomain.PacificNonAsw());
        }

        [HttpGet]
        public async Task<IActionResult> PacificAsw()
        {
            return Ok(_reportDomain.PacificAsw());
        }

        [HttpGet]
        public async Task<IActionResult> PacificCompleted()
        {
            return Ok(_reportDomain.PacificCompleted());
        }

        [HttpGet]
        public async Task<IActionResult> AtlanticCompleted()
        {
            return Ok(_reportDomain.AtlanticCompleted());
        }

        [HttpGet]
        public async Task<IActionResult> AtlanticCancelled()
        {
            return Ok(_reportDomain.AtlanticCancelled());
        }

        [HttpGet]
        public async Task<IActionResult> PacificCancelled()
        {
            return Ok(_reportDomain.PacificCancelled());
        }

        [HttpGet]
        public async Task<IActionResult> AtlanticPotential()
        {
            return Ok(_reportDomain.AtlanticPotential());
        }

        [HttpGet]
        public async Task<IActionResult> PacificPotential()
        {
            return Ok(_reportDomain.PacificPotential());
        }

        [HttpGet]
        public async Task<IActionResult> GetHullDesginationList()
        {
            return Ok(_reportDomain.GetHullDesginationList());
        }

        [HttpGet]
        public async Task<IActionResult> GetControlNumbers()
        {
            return Ok(_reportDomain.GetControlNumbers());
        }
        [HttpGet]
        public async Task<IActionResult> GetTrialStatusDescriptions()
        {
            return Ok(_reportDomain.GetTrialStatusDescriptions());
        }
        [HttpGet]
        public async Task<IActionResult> GetShips()
        {
            return Ok(_reportDomain.GetShips());
        }
        [HttpGet]
        public async Task<IActionResult> GetTestSites()
        {
            return Ok(_reportDomain.GetTestSites());
        }
        [HttpGet]
        public async Task<IActionResult> GetTestSystems()
        {
            return Ok(_reportDomain.GetTestSystems());
        }
        [HttpGet]
        public async Task<IActionResult> GetTrialStatuses()
        {
            return Ok(_reportDomain.GetTrialStatuses());
        }
        [HttpGet]
        public async Task<IActionResult> GetTrialTypes()
        {
            return Ok(_reportDomain.GetTrialTypes());
        }
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(_reportDomain.GetUsers());
        }



        protected bool CanPut(int id) { 
            return false; 
        }
        protected bool CanDelete(int id) { 
            return false; 
        }
        protected bool CanPost(UserDto dto) { 
            return false; 
        }
        protected bool CanGet() { return true; }

    }
}
