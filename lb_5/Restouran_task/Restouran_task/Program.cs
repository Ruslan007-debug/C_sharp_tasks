using Restouran_task.Abstracrion;
using Restouran_task.Controller;
using Restouran_task.Models;

namespace Restouran_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Вивiд зробив не я, вибачте, але все остальне точно я");
            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.WriteLine("║        РЕСТОРАН 'СМАЧНО' - DEMO СИСТЕМА          ║");
            Console.WriteLine("╚══════════════════════════════════════════════════╝\n");

            // Ініціалізація
            List<Order> orders = new List<Order>();
            Menu menu = new Menu();
            menu.Dishes = new List<Position>();
            RestouranController controller = new RestouranController(orders, menu);

            // ========== КРОК 1: СТВОРЕННЯ МЕНЮ ==========
            Console.WriteLine("═══════════════════════════════════════════════════");
            Console.WriteLine("КРОК 1: НАПОВНЕННЯ МЕНЮ");
            Console.WriteLine("═══════════════════════════════════════════════════\n");

            Food borsch = new Food(120, 350, "Борщ", "Україна", "Перше", 250);
            Food steak = new Food(350, 250, "Стейк", "США", "М'ясо", 450);
            Drink coffee = new Drink(false, "Гіркий", "Гарячий", "Кава", 200, 60);
            Drink juice = new Drink(false, "Солодкий", "Холодний", "Сік апельсиновий", 250, 70);

            controller.AddDishToMenu(borsch);
            controller.AddDishToMenu(steak);
            controller.AddDishToMenu(coffee);
            controller.AddDishToMenu(juice);

            Console.WriteLine("\n--- МЕНЮ РЕСТОРАНУ ---");
            controller.GetAllMenu();

            // ========== КРОК 2: ПОШУК В МЕНЮ ==========
            Console.WriteLine("\n═══════════════════════════════════════════════════");
            Console.WriteLine("КРОК 2: ПОШУК СТРАВ В МЕНЮ");
            Console.WriteLine("═══════════════════════════════════════════════════\n");

            Console.WriteLine("Клієнт шукає 'Борщ':");
            controller.FindPositionInMenu("Борщ");

            Console.WriteLine("\nКлієнт шукає 'Кава':");
            controller.FindPositionInMenu("Кава");

            // ========== КРОК 3: СТВОРЕННЯ ЗАМОВЛЕННЯ ==========
            Console.WriteLine("\n═══════════════════════════════════════════════════");
            Console.WriteLine("КРОК 3: КЛІЄНТ ПРИХОДИТЬ І СІДАЄ ЗА СТОЛИК №5");
            Console.WriteLine("═══════════════════════════════════════════════════\n");

            Order order = new Order(101, 5);
            order.SelectedFood = new List<Position>();
            controller.AddOrder(order);

            Console.WriteLine("Початковий стан замовлення:");
            controller.GetOrdersById(101);

            // ========== КРОК 4: ДОДАВАННЯ ПОЗИЦІЙ ==========
            Console.WriteLine("\n═══════════════════════════════════════════════════");
            Console.WriteLine("КРОК 4: КЛІЄНТ РОБИТЬ ЗАМОВЛЕННЯ");
            Console.WriteLine("═══════════════════════════════════════════════════\n");

            Console.WriteLine("Клієнт замовляє:");
            controller.AddPositionToOrder(101, borsch);
            controller.AddPositionToOrder(101, steak);
            controller.AddPositionToOrder(101, coffee);

            Console.WriteLine("\n--- Поточне замовлення ---");
            controller.GetOrdersById(101);

            // ========== КРОК 5: ЗМІНА РІШЕННЯ ==========
            Console.WriteLine("\n═══════════════════════════════════════════════════");
            Console.WriteLine("КРОК 5: КЛІЄНТ ПЕРЕДУМАВ");
            Console.WriteLine("═══════════════════════════════════════════════════\n");

            Console.WriteLine("Клієнт вирішив замінити каву на сік:");
            controller.DelPositionFromOrder(101, coffee);
            controller.AddPositionToOrder(101, juice);

            Console.WriteLine("\n--- Оновлене замовлення ---");
            controller.GetOrdersById(101);

            // ========== КРОК 6: ЗМІНА СТАТУСУ - ГОТУВАННЯ ==========
            Console.WriteLine("\n═══════════════════════════════════════════════════");
            Console.WriteLine("КРОК 6: ЗАМОВЛЕННЯ ПЕРЕДАНО НА КУХНЮ");
            Console.WriteLine("═══════════════════════════════════════════════════\n");

            controller.ChangeOrderStatus(101, OrderStatus.InProgress);
            controller.GetOrdersById(101);

            // ========== КРОК 7: ЗМІНА СТАТУСУ - ГОТОВЕ ==========
            Console.WriteLine("\n═══════════════════════════════════════════════════");
            Console.WriteLine("КРОК 7: СТРАВИ ГОТОВІ");
            Console.WriteLine("═══════════════════════════════════════════════════\n");

            controller.ChangeOrderStatus(101, OrderStatus.Ready);
            controller.GetOrdersById(101);

            // ========== КРОК 8: ОПЛАТА ==========
            Console.WriteLine("\n═══════════════════════════════════════════════════");
            Console.WriteLine("КРОК 8: КЛІЄНТ ОПЛАЧУЄ РАХУНОК");
            Console.WriteLine("═══════════════════════════════════════════════════\n");

            Console.WriteLine("До сплати:");
            controller.SummaryCostOfOrder(101);

            controller.ChangeOrderStatus(101, OrderStatus.Paid);
            Console.WriteLine("\nСтатус після оплати:");
            controller.GetOrdersById(101);

            // ========== ФІНАЛЬНИЙ ЧЕК ==========
            Console.WriteLine("\n═══════════════════════════════════════════════════");
            Console.WriteLine("                    ЧЕК №101");
            Console.WriteLine("═══════════════════════════════════════════════════");
            controller.GetOrdersById(101);
            Console.WriteLine("═══════════════════════════════════════════════════");
        }
    }
}
