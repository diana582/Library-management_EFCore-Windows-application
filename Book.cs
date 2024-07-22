using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDemo
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }

        public int BookCount { get; set; }
        public int isDelete { get; set; } = 0;


    }
}
