using Microsoft.AspNetCore.Mvc;
using ECFRApp.Models;

namespace ECFRApp.Controllers
{
    public class CaseFileController : Controller
    {
        // GET: CaseFile
        public IActionResult Index()
        {
            // Sample data for demonstration
            var caseFiles = new List<CaseFile>
            {
                new CaseFile
                {
                    Id = 1,
                    CaseNumber = "2024-CV-001",
                    Title = "Sample Case Filing",
                    Description = "This is a sample electronic case filing",
                    FilingDate = DateTime.Now.AddDays(-10),
                    Status = "Active",
                    FiledBy = "Attorney Smith"
                },
                new CaseFile
                {
                    Id = 2,
                    CaseNumber = "2024-CV-002",
                    Title = "Another Case Filing",
                    Description = "This is another sample electronic case filing",
                    FilingDate = DateTime.Now.AddDays(-5),
                    Status = "Pending",
                    FiledBy = "Attorney Jones"
                }
            };

            return View(caseFiles);
        }

        // GET: CaseFile/Details/5
        public IActionResult Details(int id)
        {
            var caseFile = new CaseFile
            {
                Id = id,
                CaseNumber = $"2024-CV-{id:D3}",
                Title = "Sample Case Filing",
                Description = "This is a sample electronic case filing with detailed information",
                FilingDate = DateTime.Now.AddDays(-10),
                Status = "Active",
                FiledBy = "Attorney Smith"
            };

            return View(caseFile);
        }
    }
}
