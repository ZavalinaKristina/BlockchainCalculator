using ConsoleCalc;
using ITUniver.Calc.DB.Modules;
using ITUniver.Calc.DB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCalc.Models;

namespace WebCalc.Controllers
{
    [Authorize]
    public class CalcController : Controller
    {
        private IHistoryRepository HistoryRepository = new HistoryRepository();

        private IOperationRepository OperationRepository = new OperationRepository();
        // GET: Calc
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(OperationModel model)
        {
            var calc = new Calc();
            model.Result = calc.Exec(model.Operation, model.Args.ToArray());

            var item = new HistoryItem();
            item.Args = string.Join(" ", model.Args);
            item.Operation = 1;//oper
            item.Result = model.Result;
            item.ExecDate = DateTime.Now;

            HistoryRepository.Save(item);

            return View(model);
        }
    }
}