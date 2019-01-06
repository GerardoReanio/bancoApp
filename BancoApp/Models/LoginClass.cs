using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BancoApp.Models
{
    public class LoginClass
    {
        [Required(ErrorMessage ="Ingresar UserName")]
        [Display(Name =  "UserName")]

        public string UserName {get; set;}

        [Required(ErrorMessage = "Ingresar Password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password {get; set;}


    }
}
