using pr_4.Task_1.Model;
using pr_4.Task_1.Service;
using pr_4.Task_2;
using pr_4.Task_3.Models;
using pr_4.Task_4.Enum;
using pr_4.Task_4.Model;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace pr_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task_1
            //List<TaskItem> tasks = new List<TaskItem>();
            //string filePath = "C:\\Users\\Acer\\source\\repos\\C_sharp_tasks\\PR_4\\pr_4\\pr_4\\Task_1\\tasks.json";
            //TaskServices taskService = new TaskServices();


            //taskService.LoadFromFile(filePath, tasks);

            //while (true)
            //{
            //    Console.WriteLine("\n1. Додати задачу");
            //    Console.WriteLine("2. Змінити статус");
            //    Console.WriteLine("3. Показати задачі");
            //    Console.WriteLine("4. Вийти");

            //    Console.Write("Вибір: ");
            //    string? choice = Console.ReadLine();

            //    if (choice == "1")
            //    {
            //        taskService.AddNewTask(tasks);
            //    }
            //    else if (choice == "2")
            //    {
            //        Console.WriteLine("Назва задачі яку змінити та протилежний");
            //        string? name = Console.ReadLine();
            //        taskService.ChangeTaskStatus(name!, tasks);
            //    }
            //    else if (choice == "3")
            //    {
            //        taskService.ShowAllTasks(tasks);
            //    }
            //    else if (choice == "4")
            //    {
            //        taskService.SaveToFile(tasks, filePath);
            //        break;
            //    }

            //}


            ////Task_2
            //List<Student> students = new List<Student>
            //{
            //    new Student { Name = "Alice", Age = 20, AverageScore = 85.5 },
            //    new Student { Name = "Bob", Age = 22, AverageScore = 90.0 },
            //    new Student { Name = "Charlie", Age = 19, AverageScore = 78.0 },
            //    new Student { Name = "Diana", Age = 21, AverageScore = 92.5 },
            //    new Student { Name = "Ethan", Age = 20, AverageScore = 88.0 }
            //};
            //string filePath = "C:\\Users\\Acer\\source\\repos\\C_sharp_tasks\\PR_4\\pr_4\\pr_4\\Task_2\\students.json";
            //var options = new JsonSerializerOptions
            //{
            //    WriteIndented = true
            //};

            //using (StreamWriter writer = new StreamWriter(filePath))
            //{
            //    string jsonString = JsonSerializer.Serialize(students, options);
            //    writer.Write(jsonString);
            //}

            //if (File.Exists(filePath))
            //{
            //    using (StreamReader reader = new StreamReader(filePath))
            //    {
            //        string jsonFromFile = reader.ReadToEnd();
            //        List<Student>? deserializedStudents = JsonSerializer.Deserialize<List<Student>>(jsonFromFile);
            //        if (deserializedStudents != null)
            //        {
            //            Console.WriteLine("Deserialized Students:");
            //            foreach (var student in deserializedStudents)
            //            {
            //                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Average Score: {student.AverageScore}");
            //            }
            //        }
            //    }
            //}

            ////Task_3
            //List<Book> books = new List<Book>
            //{
            //    new Book { Title = "Book 1", Author = new Author { Name = "Author 1" } },
            //    new Book { Title = "Book 2", Author = new Author { Name = "Author 1" } },
            //    new Book { Title = "Book 3", Author = new Author { Name = "Author 1" } }
            //};
            //Author author = new Author { Name = "Author 1", Books = books };

            //string filePath = "C:\\Users\\Acer\\source\\repos\\C_sharp_tasks\\PR_4\\pr_4\\pr_4\\Task_3\\authors.json";

            //var options = new JsonSerializerOptions
            //{
            //    WriteIndented = true,
            //};

            //using (StreamWriter writer = new StreamWriter(filePath))
            //{
            //    string jsonString = JsonSerializer.Serialize(author, options);
            //    writer.Write(jsonString);
            //}

            List<Order> orders = new List<Order>
            {
                new Order { Id = 1, Status = OrderStatus.Pending },
                new Order { Id = 2, Status = OrderStatus.Processing },
                new Order { Id = 3, Status = OrderStatus.Completed }
            };

            string filePath = "C:\\Users\\Acer\\source\\repos\\C_sharp_tasks\\PR_4\\pr_4\\pr_4\\Task_4\\orders.json";

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new JsonStringEnumConverter() }
            };

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string jsonString = JsonSerializer.Serialize(orders, options);
                writer.Write(jsonString);

            }

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string jsonFromFile = reader.ReadToEnd();
                    List<Order>? deserializedOrders = JsonSerializer.Deserialize<List<Order>>(jsonFromFile, options);
                    if (deserializedOrders != null)
                    {
                        Console.WriteLine("Deserialized Orders:");
                        foreach (var order in deserializedOrders)
                        {
                            Console.WriteLine($"Id: {order.Id}, Status: {order.Status}");
                        }
                    }
                }
            }
        }
    }
}
