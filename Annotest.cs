using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22UserResigstrationProblem
{
    public class Annotest
    {
        public static void Display()
        {
            CheckValidation check = new CheckValidation();
            Console.WriteLine("Enter Your Name");
            check.Name = Console.ReadLine();

            ValidationContext con = new ValidationContext(check);
            List<ValidationResult> results = new List<ValidationResult>();

            bool valid = Validator.TryValidateObject(check, con, results, true);
            if (!valid)
            {
                foreach (ValidationResult i in results)
                {
                    Console.WriteLine("Member Name : {0}", i.MemberNames);
                    Console.WriteLine("Error Message : {0}", i.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine(" Name :" + check.Name);
            }
        }
    }
}
