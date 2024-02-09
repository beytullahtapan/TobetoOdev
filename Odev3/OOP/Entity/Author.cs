using OOP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entity
{
    public class Author : User
    {
        public string FavoriteBook {  get; set; } 

        public List<Book> Books { get; set;}
    }
}
