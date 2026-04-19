using pr_5.Interfaces;
using pr_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_5.Services
{
    public class BookService
    {
        private readonly IRepository<Book> _repository;

        public BookService(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(Book book)
        {
            await _repository.AddAsync(book);
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
