using OOP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Concrete
{
    public class AuthorManager : IAuthorServices
    {
        public string GetBirthDate()
        {
            return "17.01.1995";
        }

        public string GetEmail()
        {
            return "yazar@email.com";
        }

        public string GetFullName()
        {
            return "John Doe";
        }

        public string GetLastBook()
        {
            return "John Doe Romanı";
        }

        public string GetLastBookDate()
        {
            return "09.02.2024";
        }
    }
}
