using pr_5.Interfaces;
using pr_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_5.Services
{
    public class UserService
    {
        private readonly IRepository<User> _repository;

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(User user)
        {
            await _repository.AddAsync(user);
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
