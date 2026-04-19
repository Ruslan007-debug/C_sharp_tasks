using pr_5.Infrastructure;
using pr_5.Models;
using pr_5.Repositories;
using pr_5.Services;

namespace pr_5
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var serializer = new JsonDataSerializer();
            var provider = new FileStorageProvider();

            var userService = new UserService(
                new JsonRepository<User>(serializer, provider, "users.json"));

            var bookService = new BookService(
                new JsonRepository<Book>(serializer, provider, "books.json"));

            var orderService = new OrderService(
                new JsonRepository<Order>(serializer, provider, "orders.json"));

            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("=== MAIN MENU ===");
                Console.WriteLine("1 - Users");
                Console.WriteLine("2 - Books");
                Console.WriteLine("3 - Orders");
                Console.WriteLine("0 - Exit");

                var choice = Console.ReadLine();

                if (choice == "1")
                {
                    await UserMenu(userService);
                }

                if (choice == "2")
                {
                    await BookMenu(bookService);
                }

                if (choice == "3")
                {
                    await OrderMenu(orderService, userService, bookService);
                }

                if (choice == "0")
                {
                    isRunning = false;
                }
            }
        }

        // ================= USERS =================
        static async Task UserMenu(UserService service)
        {
            bool run = true;

            while (run)
            {
                Console.Clear();
                Console.WriteLine("=== USERS ===");
                Console.WriteLine("1 - Add");
                Console.WriteLine("2 - Show");
                Console.WriteLine("0 - Back");

                var c = Console.ReadLine();

                if (c == "1")
                {
                    Console.Write("Name: ");
                    var name = Console.ReadLine();

                    await service.AddAsync(new User
                    {
                        Id = new Random().Next(1, 100000),
                        Name = name
                    });

                    Console.WriteLine("Added!");
                    Console.ReadKey();
                }

                if (c == "2")
                {
                    var users = await service.GetAllAsync();

                    foreach (var u in users)
                    {
                        Console.WriteLine($"{u.Id} - {u.Name}");
                    }

                    Console.ReadKey();
                }

                if (c == "0")
                {
                    run = false;
                }
            }
        }

        // ================= BOOKS =================
        static async Task BookMenu(BookService service)
        {
            bool run = true;

            while (run)
            {
                Console.Clear();
                Console.WriteLine("=== BOOKS ===");
                Console.WriteLine("1 - Add");
                Console.WriteLine("2 - Show");
                Console.WriteLine("0 - Back");

                var c = Console.ReadLine();

                if (c == "1")
                {
                    Console.Write("Title: ");
                    var title = Console.ReadLine();

                    await service.AddAsync(new Book
                    {
                        Id = new Random().Next(1, 100000),
                        Title = title
                    });

                    Console.WriteLine("Added!");
                    Console.ReadKey();
                }

                if (c == "2")
                {
                    var books = await service.GetAllAsync();

                    foreach (var b in books)
                    {
                        Console.WriteLine($"{b.Id} - {b.Title}");
                    }

                    Console.ReadKey();
                }

                if (c == "0")
                {
                    run = false;
                }
            }
        }

        // ================= ORDERS =================
        static async Task OrderMenu(
            OrderService orderService,
            UserService userService,
            BookService bookService)
        {
            bool run = true;

            while (run)
            {
                Console.Clear();
                Console.WriteLine("=== ORDERS ===");
                Console.WriteLine("1 - Create Order");
                Console.WriteLine("2 - Show Orders");
                Console.WriteLine("0 - Back");

                var c = Console.ReadLine();

                if (c == "1")
                {
                    var users = await userService.GetAllAsync();
                    var books = await bookService.GetAllAsync();

                    Console.WriteLine("Users:");
                    foreach (var u in users)
                    {
                        Console.WriteLine($"{u.Id} - {u.Name}");
                    }

                    Console.Write("Choose UserId: ");
                    int userId = int.Parse(Console.ReadLine());

                    Console.WriteLine("Books:");
                    foreach (var b in books)
                    {
                        Console.WriteLine($"{b.Id} - {b.Title}");
                    }

                    Console.Write("Choose BookId: ");
                    int bookId = int.Parse(Console.ReadLine());

                    await orderService.AddAsync(new Order
                    {
                        Id = new Random().Next(1, 100000),
                        UserId = userId,
                        BookId = bookId
                    });

                    Console.WriteLine("Order created!");
                    Console.ReadKey();
                }

                if (c == "2")
                {
                    var orders = await orderService.GetAllAsync();

                    foreach (var o in orders)
                    {
                        Console.WriteLine($"Order {o.Id} | UserId: {o.UserId} | BookId: {o.BookId}");
                    }

                    Console.ReadKey();
                }

                if (c == "0")
                {
                    run = false;
                }
            }
        }
    }
}