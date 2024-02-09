using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface
{
    public interface IAuthorServices : IUserServices
    {
        string GetLastBook();
        string GetLastBookDate();
    }
}
