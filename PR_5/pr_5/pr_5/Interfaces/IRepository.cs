using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_5.Interfaces
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAllAsync();
        Task AddAsync(T item);
    }

}
