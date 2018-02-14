using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITUniver.Calc.DB.Modules;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
//using System.Globalization;

namespace ITUniver.Calc.DB.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class, IEntity
    {
        //todo: вынести в конфиг
        protected string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\BlockchainCalculator\ITUniver.Calc.DB\App_Data\CalcDB.mdf;Integrated Security=True";
        protected string tableName { get; set; }

        public BaseRepository()
        {
            this.tableName = typeof(T).Name;
        }
        public BaseRepository(string tableName)
        {
            this.tableName = tableName;
        }
        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public T Find(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return ReadData();
        }

        public void Save(T item)
        {
            var props = typeof(T).GetProperties()
                .Where(p => p.Name != "Id")
                .OrderBy(p => p.Name);
            var colums = props.Select(prop => prop.Name);
            var values = new List<string>();
            foreach (var prop in props)
            {
                var value = prop.GetValue(item);
                var str = $"{value}";
                if (value == null)
                {
                    str = "null";
                }
                else if (value is string)
                {
                    str = $"N'{value}'";
                }
                else if (value is DateTime)
                {
                    var date = (DateTime)value;
                    str = $"N'{date.ToString(CultureInfo.InvariantCulture)}'";
                }
                else if (value is double)
                {
                    var doubleValue = (double)value;
                    str = $"{doubleValue.ToString(CultureInfo.InvariantCulture)}";
                }
                //todo boolean

                values.Add(str);
            }

            var strColumns = "[" + string.Join("], [", colums) + "]";
            var strValues = string.Join(",", values);
            var insertQuery = 
                $"INSERT INTO [dbo].[{tableName}] ({strColumns}) VALUES ({strValues})";

            string queryString = item.Id > 0 ? "UPDATE * FROM [dbo].[History]"
                : insertQuery;
             using (var connection = new SqlConnection(connectionstring))
             {
                 var command = new SqlCommand(queryString, connection);
                 connection.Open();

                 var count = command.ExecuteNonQuery();               
             }

        }



        #region
        private IEnumerable<T> ReadData()
        {
            var items = new List<T>();
            string queryString =
                $"SELECT * FROM [dbo].[{tableName}]";

            using (var connection = new SqlConnection(connectionstring))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    items.Add(ReadSingleRow(reader));
                }

                reader.Close();
            }
            return items;
        }

        private T ReadSingleRow(IDataRecord record)
        {
            var obj = Activator.CreateInstance<T>();
            var tclass = typeof(T);
            var props = tclass.GetProperties();
            foreach (var prop in props)
            {
                // var value = record[prop.Name];
                var ind = record.GetOrdinal(prop.Name);
                var isnull = record.IsDBNull(ind);
                if (!isnull)
                {
                    var value = record[prop.Name];
                    prop.SetValue(obj, value);
                }
            }
            return obj;
        }


        #endregion
    }
}
