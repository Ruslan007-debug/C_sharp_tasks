
using Modular_1.Task_1.Delegates;
using Modular_1.Task_1.Operations;
using Modular_1.Task_1.Processors;
using Modular_1.Task_2.Logger;
using Modular_1.Task_2.Publisher;

namespace Modular_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task1
            //string inputFile = "C:\\Users\\Acer\\source\\repos\\C_sharp_tasks\\Modular_1\\Modular_1\\Modular_1\\Task_1\\textPD21.txt";
            //string outputFile = "C:\\Users\\Acer\\source\\repos\\C_sharp_tasks\\Modular_1\\Modular_1\\Modular_1\\Task_1\\resultPD21.txt";

            // File.WriteAllText(outputFile, "");

            // FileProcessor.Process(inputFile, outputFile, ToUpper.ConvertToUpper);
            // FileProcessor.Process(inputFile, outputFile, CountChars.CountCharsFunc);
            // FileProcessor.Process(inputFile, outputFile, CountWords.CountWordsFunc);

            //Task2
            string filePath = "C:\\Users\\Acer\\source\\repos\\C_sharp_tasks\\Modular_1\\Modular_1\\Modular_1\\Task_2\\logPD21.txt";

            File.WriteAllText(filePath, "");

            MessagePublisher publisher = new MessagePublisher();
            FileLogger logger = new FileLogger(filePath);

            logger.Subscribe(publisher);

            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();

                publisher.Send(input);
            }

        }
    }
}
