using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_503___Abstraction__Polymorphism_Homework
{
    public interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
}
