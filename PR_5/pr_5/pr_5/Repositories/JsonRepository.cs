using pr_5.Infrastructure;
using pr_5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_5.Repositories
{
    public class JsonRepository<T>: IRepository<T>
    {
        private readonly IDataSerializer _serializer;
        private readonly string _filePath;

        public JsonRepository(IDataSerializer serializer, FileStorageProvider provider, string fileName)
        {
            _serializer = serializer;
            _filePath = provider.GetFilePath(fileName);
        }

        public async Task AddAsync(T item)
        {
            var items = await GetAllAsync();
            items.Add(item);
            await _serializer.WriteAsync(_filePath, items);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _serializer.ReadAsync<T>(_filePath);
        }

    }
}
