using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.Rastgele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MIN = 1;
            const int MAX = 8;
            Random r = new Random();
            int[] array = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    // Çalışmıyor.
                    while (array[i]==array[j])
                    {
                        array[i] = 0;
                        array[i] += r.Next(MIN, MAX);
                    }
                }
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
