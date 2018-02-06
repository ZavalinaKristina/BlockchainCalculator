using ITUniver.Calc.Core.Interface;
using ITUniver.Calc.Core.Operations;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleCalc
{
    public class Calc
    {
        private IList<IOperation> operations { get; set; }

        public Calc()
        {
            operations = new List<IOperation>();
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();
            foreach (var item in types)
            {
                var interfaces = item.GetInterfaces();
                var isOperation = interfaces.Any(
                    it => it == typeof(IOperation));

                if (isOperation)
                {
                    //создаем экз. объекта
                    var obj = Activator.CreateInstance(item);
                    //приводим его в операцию
                    var operation = obj as IOperation;
                    //если удалось
                    if (operation != null)
                    {
                        //добавляем в список операций
                        operations.Add(operation);
                    }
                }
            }
        }

        /// <summary>
        /// Получить список имен операций
        /// </summary>
        /// <returns></returns>
        public string[] GetOperNames()
        {
            return operations.Select(o => o.Name).ToArray();
        }
        public double Exec(string oper, double[] args)
        {
            //найти операцию в списке 
            var operation = operations
                .FirstOrDefault(o => o.Name == oper);

            //если не найдена - возвращаем ошибку
            if (operation == null)
                return double.NaN;

            //если нашли
            //передаем ей аргументы и вычисляем результат
            var result = operation.Exec(args);

            //возвращаем результат 
            return result;
        }
    }
}
