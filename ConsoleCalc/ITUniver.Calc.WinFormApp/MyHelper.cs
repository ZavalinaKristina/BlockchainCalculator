using ITUniver.Calc.DB.Modules;
using ITUniver.Calc.DB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.Calc.WinFormApp
{
    public static class MyHelper
    {
        private static IHistoryRepository History = new MemoryRepository();
        private static IList<IHistoryItem> items = new List<IHistoryItem>();

        public static void AddToHistory(string oper, double[] args, double result)
        {
            var item = new HistoryItem();
            item.Args = string.Join(" ", args);
            item.Operation = oper;
            item.Result = result;
            item.ExecDate = DateTime.Now;

            History.Save(item);
        }

        public static string GetAll()
        {
            string s = "";
            var histr = History.GetAll();
            foreach (var item in histr)
            {
                s += item.Result + " "; //не знаю, в каком виде должно быть. Пусть пока так.
            }


            return s;
        }
    }
}
