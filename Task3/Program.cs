using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Text.txt";
            // Наверное, не самое лучше решение с точки зрения производительности, но зато локонично)))
            Console.WriteLine($"Количество символов: {File.ReadAllText(path).Length}");
            Console.WriteLine($"Количество строк: {File.ReadAllLines(path).Length}");
            Console.WriteLine($"Количество слов: {File.ReadAllText(path).Split().Length}");
            Console.ReadKey();
        }

    }
}
