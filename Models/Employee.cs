using System.ComponentModel.DataAnnotations;

namespace Demo2MVC.Models
{
    public class Employee
    {
        [Required]
        [Display(Name = "Employee Id")]
        [DataType(DataType.Text)]

        public int Id { get; set; }


        [Required]
        [MinLength(2)]
        [MaxLength(40)]
        [DataType(DataType.Text)]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }

        [Required]
        [Range(minimum:18, maximum:59)]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Email Adress")]
        [MaxLength(40)]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Date of Joining")]
        public DateTime Doj { get; set; }

        [Required]
        public int Salary { get; set; }
    }
}

                    /*  Data Annotations

                    In MVC when we want to apply validation to the view page, we will apply validations using model class , i.e. with help of Data Annotations.

                    We can categories the validation in 3 ways
                    Required → fields which are required , can not be blank or empty 
		                    Example → name,email,contact, 
                    Pattern → need to accept values based on predefined patterns or rules
                                    Example – >email id format, pwd format, postal code
                    Range → accept values within the range
                                   Example age -> 18 - 60   min price =0  max price -2000

                    How to apply data annotations in MVC
                    I.e. with the help of attributes. Attributes will be applied using [ ]

                     */