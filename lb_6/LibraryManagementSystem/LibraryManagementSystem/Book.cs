using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book : LibraryItemBase
    {
        public string Author { get; set; }

        public Book(string title, int year, string author): base(title, year)
        {
            Author = author;
        }
        public override string GetItemType()
        {
            return "Book";
        }

        public override string GetDisplayInfo()
        {
            var s = base.GetDisplayInfo() + " " + $"Author: {Author}";
            return s;
        }
    }
}
