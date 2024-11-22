using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_503___Abstraction__Polymorphism_Homework
{
    public class User : IAccount
    {
        private byte ID { get; set; }
        public static byte Count;
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }



        public bool PasswordChecker(string password)
        {

            //if (password.Length < 8)
            //{
            //    return false;
            //}
            //bool IsNumber = false;
            //foreach (char c in password)
            //{
            //    if (char.IsDigit(c))
            //    {
            //        return true;
            //    }
            //}
            //if (!IsNumber)
            //{
            //    return false;
            //}

            bool IsUpper = false;
            bool IsLower = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    return true;
                }
            }
            if (!IsUpper)
            {
                return false;
            }

            foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                    return true;
                }
            }
            if (!IsLower)
            {
                return false;
            }




            return true;
        }

        public void ShowInfo()
        {
            Count++;
            ID = Count;
            Console.WriteLine($" ID - {ID}, Fullname - {Fullname}, Email - {Email}");
        }
    }
}
