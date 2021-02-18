using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace poopi.Areas.Student.Controllers
{
    public class StudentPanelController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}