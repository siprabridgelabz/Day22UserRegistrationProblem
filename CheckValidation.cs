using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22UserResigstrationProblem
{
    public class CheckValidation
    {

        // [Required(ErrorMessage = "Property check {0} is required")]
        // [StringLength(100,MinimumLength =3 ,ErrorMessage = "Name should be minimum 3 character" )]
        [RegularExpression("^[A-Z]{1}[A-Za-z]{2,}$", ErrorMessage = "Name should be minimum 3 character and start with caps")]
        [DataType(DataType.Text)]

        public string FirstName { get; set; }

        [RegularExpression("^[A-Z]{1}[A-Za-z]{2,}$", ErrorMessage = "Name should be minimum 3 character and start with caps")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
}

