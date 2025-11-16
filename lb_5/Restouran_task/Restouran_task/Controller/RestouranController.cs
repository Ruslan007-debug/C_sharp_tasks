using Restouran_task.Abstracrion;
using Restouran_task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restouran_task.Controller
{
    public class RestouranController
    {
        List<Order> Orders { get; set; }
        public Menu Menu { get; set; }

        public RestouranController(List<Order> orders, Menu menu)
        {
            this.Orders = orders;
            this.Menu = menu;
        }
        public void GetOrders()
        {
            foreach (var order in Orders)
            {
                order.GetOrder();
                Console.WriteLine("----------------------------");
            }
        }
        public void GetOrdersById(int id)
        {
            foreach (var order in Orders)
            {
                if (order.Id == id)
                {
                    order.GetOrder();
                }
            }
        }
        public void AddOrder(Order order)
        {
            Orders.Add(order);
            Console.WriteLine($"Added order with id: {order.Id}");
        }
        public void RemoveOrder(int id)
        {
            var order = Orders.FirstOrDefault(o => o.Id == id);

            if (order == null)
            {
                Console.WriteLine($"Order with id {id} not found");
                return;
            }

            Orders.Remove(order);
            Console.WriteLine($"Deleted order with id: {order.Id}");
        }
        public void AddPositionToOrder(int id, Position dish)
        {
            foreach (var order in Orders)
            {
                if (order.Id == id)
                {
                    order.AddPosition(dish);
                }
            }
            
        }
        public void DelPositionFromOrder(int id, Position dish)
        {
            foreach (var order in Orders)
            {
                if (order.Id == id)
                {
                    order.DeletePosition(dish);
                }
            }
        }
        public void SummaryCostOfOrder(int id)
        {
            foreach (var order in Orders)
            {
                if (order.Id == id)
                {
                    order.SummaryCost();
                }
            }
        }
        public void ChangeOrderStatus(int id, OrderStatus status)
        {
            foreach (var order in Orders)
            {
                if (order.Id == id)
                {
                    order.ChangeStatus(status);
                }
            }
        }
        public void GetAllMenu()
        {
            Console.WriteLine("Watch menu");
            Menu.GetMenu();
        }
        public void FindPositionInMenu(string name)
        {
            Console.WriteLine("Find dish by name");
            Menu.GetDish(name);
        }
        public void AddDishToMenu(Position dish)
        {
            Console.WriteLine("Add to menu");
            Menu.AddToMenu(dish);
        }
        public void DelDishFromMen(Position dish)
        {
            Console.WriteLine("Deleting from menu");
            Menu.DeleteFromMenu(dish);
        }
    }
}
