using ITUniver.Calc.DB.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.Calc.DB.Repositories
{

    public interface IUserRepository : IBaseRepository<User>
    {
        /// <summary>
        /// Проверить наличие пользователя с таким логином
        /// </summary>
        /// <param name="login">Имя пользователя</param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool Check(string login, string password);

        /// <summary>
        /// Сохранить пользователя
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        //void Save(User user);
        /// <summary>
        /// Загрузить пользователя по имени
        /// </summary>
        /// <param name="login">Имя пользователя</param>
        /// <returns></returns>
        User GetByName(string login);
     }

}
