using ITUniver.Calc.Core.Interface;
using ITUniver.Calc.Core.Operations;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ConsoleCalc
{
    public class Calc
    {
        private IList<IOperation> operations { get; set; }

        public Calc()
        {
            operations = new List<IOperation>();
            //загружаем текущие
            LoadOperation(Assembly.GetExecutingAssembly());

            //загружаем сторонние библиотеки
            var extensionsDir = Path.Combine(Environment.CurrentDirectory, "Extensions");
            if (!Directory.Exists(extensionsDir))
                return;

            var files = Directory.GetFiles(extensionsDir, "*.dll");
            foreach (var file in files)
            {
                LoadOperation(Assembly.LoadFile(files.FirstOrDefault()));
            }
        }

        private void LoadOperation(Assembly assembly)
        {
            var types = assembly.GetTypes();
            var typeOperation = typeof(IOperation);
            foreach (var item in types.Where(t => !t.IsAbstract && !t.IsInterface))
            {
                var interfaces = item.GetInterfaces();
                var isOperation = interfaces.Any(it => it == typeOperation);

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
