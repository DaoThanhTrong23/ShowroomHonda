using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShowroomHonda.Models;

namespace ShowroomHonda.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        QL_HONDA_SHOWROOMEntities1 data = new QL_HONDA_SHOWROOMEntities1();

    

        public ActionResult showDSTK()
        {
            var list = data.THONGSOKYTHUATs.ToList();
            return View(list);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}