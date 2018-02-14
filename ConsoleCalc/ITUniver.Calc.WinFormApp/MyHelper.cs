﻿using ITUniver.Calc.DB.Modules;
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
        private static IBaseRepository<HistoryItem> History = new BaseRepository<HistoryItem>("History");
        // private static IList<IHistoryItem> items = new List<IHistoryItem>();

        public static void AddToHistory(string oper, double[] args, double result)
        {
            var item = new HistoryItem();
            item.Args = string.Join(" ", args);
            item.Operation = 1;//oper
            item.Result = result;
            item.ExecDate = DateTime.Now;

            History.Save(item);
        }

        public static string[] GetAll()
        {
            //sum(1,3,4) = 8/ 01.08.2018
            if (History != null)
            {
                return History.GetAll()
                     .Select(hi => $"{hi.Operation}({hi.Args}) = {hi.Result}/ {hi.ExecDate}")
                     .ToArray();
            }
            else
            {
                return null;
            }
        }
    }
}
