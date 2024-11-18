using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_2_A_2024_74154.Models
{
    public class Book
    {
        public string Title { get; set; }
        public bool IsBorrowed { get; set; }

        public Book(string title)
        {
            Title = title;
            IsBorrowed = false;
        }
    }
}
