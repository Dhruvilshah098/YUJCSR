﻿using Microsoft.AspNetCore.Mvc;
using YUJCSR.Web.CSO.BusinessManager;
using YUJCSR.Web.CSO.Models;

namespace YUJCSR.Web.CSO.Controllers
{
    public class UserController : Controller
    {
        IConfiguration _config;
        public UserController(IConfiguration iConfig)
        {
            _config = iConfig;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(CSOProfileModel cso)
        {

            CSOManager manager = new CSOManager(_config);
            var status = manager.OnBoardCSO(cso);
            if (status)
            {
                ViewBag.message = "Success";
            }
            else
            {
                ViewBag.message = "Failure";
            }
            return View();
        }
        public IActionResult Onboarding()
        {
            return View();
        }
    }
}
