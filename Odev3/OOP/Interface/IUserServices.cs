using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface
{
    public interface IUserServices
    {
        string GetFullName();
        string GetBirthDate();
        string GetEmail();
    }
}
