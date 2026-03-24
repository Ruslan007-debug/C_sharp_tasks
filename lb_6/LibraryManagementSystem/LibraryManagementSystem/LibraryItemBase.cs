using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public abstract class LibraryItemBase : ILibraryItem
    {
        public int Id { get;}
        public string Title { get ; set; }
        public int Year { get; set; }

        static int  _nextId;
        public  LibraryItemBase(string title, int year)
        {
            Title = title;
            Year = year;
            Id = _nextId++;
        }
        public abstract string GetItemType();

        public virtual string GetDisplayInfo()
        {
            return $"{GetItemType()} ID: {Id}, Title: \"{Title}\", Year: {Year}";
        }
    }
}
