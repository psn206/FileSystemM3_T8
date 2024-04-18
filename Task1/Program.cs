using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Temp";
            string[] dirArr = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("Все каталоги и подкоталоги:");
            foreach (string dir in dirArr)
            {
                Console.WriteLine(dir);
            }
            string[] dirFile = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("Все файлы:");
            foreach (string file in dirFile)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
