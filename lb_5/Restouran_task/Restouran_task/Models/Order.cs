using Restouran_task.Abstracrion;
using Restouran_task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restouran_task.Models
{
    public enum OrderStatus
    {
        New,
        InProgress,
        Ready,
        Paid
    }
    public class Order: IOrder
    {
        public int Id { get; set; }
        public int Table { get; set; }
        public List<Position> SelectedFood { get; set; }
        public OrderStatus Status { get; set; }

        public Order(int id, int table)
        {
            this.Id = id;
            this.Table = table;
            this.Status = OrderStatus.New;

        }

        public void AddPosition(Position dish)
        {
            SelectedFood.Add(dish);
            Console.WriteLine($"Added to order: {dish.Name}");
        }

        public void DeletePosition(Position dish)
        {
            var deletedFood = SelectedFood.FirstOrDefault(food => food == dish);

            if (deletedFood == null)
            {
                Console.WriteLine($"Dish: {dish.Name} is not in order");
                return;
            }

            SelectedFood.Remove(deletedFood);
            Console.WriteLine($"Deleted from order: {deletedFood.Name}");
        }

        public void SummaryCost()
        {
            int SumCost = 0;
            foreach(var dish in SelectedFood)
            {
                SumCost += dish.Cost;
            }
            Console.WriteLine($"Summary cost of order: {SumCost} hrn");
        }

        public void GetOrder()
        {
            Console.WriteLine($"Order Id: {Id}");
            Console.WriteLine($"Table: {Table}");
            Console.WriteLine("Selected food:");
            foreach (var dish in SelectedFood)
            {
                Console.WriteLine(dish.Name);
            }
            SummaryCost();
            Console.WriteLine($"Order status: {Status}");
        }

        public void ChangeStatus(OrderStatus status)
        {
            Status = status;
            Console.WriteLine($"Status changed to: {status}");
        }
    }

}
