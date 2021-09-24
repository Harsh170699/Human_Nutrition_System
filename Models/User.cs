using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionWebApp.Models
{
    public class User
    {
        [Key]   // user id will be primary key
        public int UserID { get; set; }

        [Required(ErrorMessage = "name is required")]
        public string name { get; set; }

        [Required(ErrorMessage = "age is required")]
        public int age { get; set; }

        [Required(ErrorMessage = "Height is required")]
        public int height { get; set; }

        [Required(ErrorMessage = "Weight is required")]
        public int weight { get; set; }

        [Required(ErrorMessage = "Waist is required")]
        public int waist { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password not matched")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        //[Display(Name = "Role")]
        //[Required(ErrorMessage = "{0} cannot be empty")]
        //public int Role { get; set; }

        //[Display(Name = "Expert_Name")]
        //[Required(ErrorMessage = "{0} cannot be empty")]
        //public string exp_name { get; set; }

        //[Display(Name = "Expert_Phone")]
        //[Required(ErrorMessage = "{0} cannot be empty")]
        //[Phone]
        //public int exp_phone { get; set; }

        //[Display(Name = "Expert_Email")]
        //[Required(ErrorMessage = "{0} cannot be empty")]
        //public string exp_email { get; set; }

        //[Display(Name = "Address")]
        //[Required(ErrorMessage = "{0} cannot be empty")]
        //public string adress { get; set; }

    }
}
