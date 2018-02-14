using ITUniver.Calc.DB.Modules;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.Calc.DB.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private User user = new User(); 
        public bool Check(string login, string password)
        {
            //todo - не оптимально!
            return GetAll().Any(u => u.Login == login && u.Password == password);

        }

        public User GetByName(string login)
        {
            throw new NotImplementedException();
        }
    }
}
