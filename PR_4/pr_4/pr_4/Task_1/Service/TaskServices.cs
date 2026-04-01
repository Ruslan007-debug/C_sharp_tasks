using pr_4.Task_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace pr_4.Task_1.Service
{
    public class TaskServices
    {
        public void AddNewTask(List<TaskItem> tasks)
        {
            Console.Write("Введи назву задачі: ");
            string title = Console.ReadLine();

            TaskItem task = new TaskItem();
            task.Title = title;
            task.IsCompleted = false;

            tasks.Add(task);
        }

        public void ChangeTaskStatus(string name, List<TaskItem> tasks)
        {
            foreach (var task in tasks)
            {
                if (task.Title == name)
                {
                    task.IsCompleted = !task.IsCompleted;
                    Console.WriteLine($"Статус задачі '{name}' змінено на {(task.IsCompleted ? "завершено" : "незавершено")}.");

                }
            }
        }

        public void ShowAllTasks(List<TaskItem> tasks)
        {
            Console.WriteLine("Список всік задач: ");
            foreach (var task in tasks)
            {
                Console.WriteLine($"Назва: {task.Title}, Статус: {(task.IsCompleted ? "завершено" : "незавершено")}");
            }
        }

        public void SaveToFile(List<TaskItem> tasks, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var task in tasks)
                {
                    string json = JsonSerializer.Serialize(task);
                    writer.WriteLine(json);

                }
            }
        }

        public void LoadFromFile(string filePath, List<TaskItem> tasks)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()!) != null)
                    {
                        TaskItem task = JsonSerializer.Deserialize<TaskItem>(line);
                        if (task != null)
                        {
                            tasks.Add(task);
                        }
                        
                    }
                }
            }
            else
            {
                Console.WriteLine("Файл не знайдено. Створено новий список задач.");
            }
        }
    }
}
