using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApi.Domain.Entities;
using WebApi.Service;

namespace WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            ProjectManagerEntities _context = new ProjectManagerEntities();
            var model = _context.Projects;
            return View(model);
        }
    }
}
