using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_5.Interfaces
{
    public interface IDataSerializer
    {
        Task<List<T>> ReadAsync<T>(string filePath);
        Task WriteAsync<T>(string filePath, List<T> data);
    }
}
