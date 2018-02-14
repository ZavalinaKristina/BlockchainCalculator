using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace WebCalc.Controllers
{

    [Authorize]
    public class OperationController : Controller
    {
        // GET: Operation
        public ActionResult Index()
        {
           /* var operation = new List<Operation>()
            {
                 
        }*/
            return View();
        }
    }
}