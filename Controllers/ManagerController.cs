using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShowroomHonda.Models;
using System.ComponentModel.DataAnnotations;

namespace ShowroomHonda.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        QL_HONDA_SHOWROOMEntities1 data = new QL_HONDA_SHOWROOMEntities1();

        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]

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