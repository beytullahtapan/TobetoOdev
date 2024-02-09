using OOP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Concrete
{
    public class BookManager : IBookServices
    {
        public string GetBookCategory()
        {
            return "Roman";
        }

        public string GetBookTitle()
        {
            return "Deneme Romanı";
        }

        public int GetPageCount()
        {
            return 150;
        }
    }
}
