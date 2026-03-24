using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public interface ILibraryItem
    {
        public int Id { get; }
        public string  Title { get; set; }
        public int Year { get; set; }

        public string  GetDisplayInfo();
    }
}
