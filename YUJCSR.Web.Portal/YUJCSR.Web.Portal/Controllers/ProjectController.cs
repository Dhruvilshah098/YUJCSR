using Microsoft.AspNetCore.Mvc;
using System;
using YUJCSR.Web.Portal.Business;
using YUJCSR.Web.Portal.Models;

namespace YUJCSR.Web.Portal.Controllers
{
    public class ProjectController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ProjectManager obj = new ProjectManager();
            var list = obj.GetProjects();
            //var list = (APIResponse)data.Result;
            ViewBag.Projects =  list;
            return View();
        }

        public IActionResult Details(string id)
        {
            ProjectManager obj = new ProjectManager();
            var project = obj.GetProjects().FirstOrDefault(x => x.ProjectID == id);
            //var list = (APIResponse)data.Result;
            ViewBag.Project = project;
            return View();
        }
    }
}