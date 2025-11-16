using Restouran_task.Abstracrion;
using Restouran_task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restouran_task.Interfaces
{
    public interface IOrder
    {
        public void AddPosition(Position dish);
        public void DeletePosition(Position dish);
        public void SummaryCost();
        public void GetOrder();
        public void ChangeStatus(OrderStatus status);


    }
}
