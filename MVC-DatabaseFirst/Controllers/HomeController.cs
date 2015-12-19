using MVCDatabaseFirst.Data.Infrastructure;
using MVCDatabaseFirst.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCDatabaseFirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var objRepo = new EmployeeRepository(new DatabaseFactory());

            var result = objRepo.GetAll();

            return View();
        }
    }
}
