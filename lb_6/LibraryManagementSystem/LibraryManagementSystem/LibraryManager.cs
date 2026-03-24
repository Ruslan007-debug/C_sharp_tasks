using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class LibraryManager
    {
        LibraryCatalog<Book> _bookCatalog;
        LibraryCatalog<Magazine> _magazineCatalog;

        public LibraryManager()
        {
            _bookCatalog = new LibraryCatalog<Book>();
            _magazineCatalog = new LibraryCatalog<Magazine>();
        }

        public void AddItem(ILibraryItem item)
        {
            if (item is Book book)
            {
                _bookCatalog.AddItem(book);
            }
            else if (item is Magazine magazine)
            {
                _magazineCatalog.AddItem(magazine);
            }
        }

        public List<ILibraryItem> GetAllItems()
        {
            List<ILibraryItem> allItems = new List<ILibraryItem>();

            allItems.AddRange(_bookCatalog.GetAllItems());
            allItems.AddRange(_magazineCatalog.GetAllItems());

            return allItems;
        }

        public ILibraryItem? GetItemById(int id)
        {
            var list = GetAllItems();
            foreach (var item in list)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null; 
        }
    }
}