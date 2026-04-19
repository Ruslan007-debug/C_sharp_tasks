using pr_5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace pr_5.Infrastructure
{
    public class JsonDataSerializer : IDataSerializer
    {
        public async Task<List<T>> ReadAsync<T>(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<T>();
            }
            var json = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        public async Task WriteAsync<T>(string filePath, List<T> data)
        {
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            await  File.WriteAllTextAsync(filePath, json);
        }
    }
}
