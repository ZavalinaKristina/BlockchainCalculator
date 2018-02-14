using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebCalc.Models
{
    public class LoginModel
    {
       
        [Display(Name = "Логин")]
        [Required (AllowEmptyStrings = false, ErrorMessage = "Ты кто такой?!" )]
        public string Login { get; set; }

        [Display(Name = "Пароль")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Без пароля нельзя")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Имя пользователя")]
        public string Name { get; set; }

        [Display(Name = "Дата рождения")]
        public DateTime BirthDay { get; set; }

        [Display(Name = "Пол")]
        public bool Sex { get; set; }




    }
}