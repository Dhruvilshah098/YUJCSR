using Microsoft.AspNetCore.Mvc;
using YUJCSR.Web.CSO.BusinessManager;

namespace YUJCSR.Web.CSO.Controllers
{
    public class ProjectController : Controller
    {
        IConfiguration _config;
        public ProjectController(IConfiguration iConfig)
        {
            _config = iConfig;
        }


        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

      //  [Route("/project/budget/{project-id}")]
        public IActionResult Budget(string projectId)
        {
            ProjectManager manager = new ProjectManager(_config);
            var data = manager.GetBudgets(projectId);

            return View("Budget", data);
        }

		//[Route("/project/milestone/{project-id}")]
		public IActionResult Milestones(string projectId)
        {
            ProjectManager manager = new ProjectManager(_config);
            var data = manager.GetMilestones(projectId);
            return View("Milestone", data);
        }

        public IActionResult Index()
        {
            ProjectManager manager = new ProjectManager(_config);
            var data = manager.GetProjects();

            return View("Index", data);
        }
    }
}
