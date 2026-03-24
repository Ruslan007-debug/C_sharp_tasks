using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class LibraryCatalog<T> where T : ILibraryItem
    {
        public List<T> _items;
        public LibraryCatalog()
        {
            _items = new List<T>();
        }
        public void AddItem(T item)
        {
            _items.Add(item);
        }

        public List<T> GetAllItems()
        {
            return _items;
        }

        public T GetItemById(int id)
        {

            foreach (var item in _items)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return default(T);

        }
    }
}
