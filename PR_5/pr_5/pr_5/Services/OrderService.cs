using pr_5.Interfaces;
using pr_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_5.Services
{
    public class OrderService
    {
        private readonly IRepository<Order> _repository;

        public OrderService(IRepository<Order> repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(Order order)
        {
            await _repository.AddAsync(order);
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
