using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deneme.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = aboutManager.GetList();
            return View(values);
        }
        [AllowAnonymous]
        public PartialViewResult SocialMediaAbout()
        {           
            return PartialView();
        }

    }
}
