using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Number.txt";
            int numNum = 10, sum = 0;
            Random random = new Random();

            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < numNum; i++)
                {
                    sw.WriteLine(random.Next(0, 10));
                }
            }
            using (StreamReader sr = new StreamReader(path))
                for (int i = 0; i < numNum; i++)
                {
                    sum += Convert.ToInt32(sr.ReadLine());
                }
            Console.WriteLine($"Сумма = {sum}");
            Console.ReadKey();
        }
    }
}
