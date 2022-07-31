using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.Dikucgen
{
    internal class Program
    {
        static void Main(string[] args)
        {
                #region KenarSayısı4olsun
                // 4 yıldız kenar başına, içi boş kare
                int[,] stars = new int[4, 4];
                for (int i = 0; i < stars.GetLength(0); i++)
                {
                    {
                        Console.WriteLine("");
                    }
                    for (int j = 0; j < stars.GetLength(1); j++)
                    {
                        // koşul sayısı düşürülebilir mi?
                        if (i == 1 && j == 1)
                        {
                            Console.Write(" ");
                        }
                        else if (i == 1 && j == 2)
                        {
                            Console.Write(" ");
                        }
                        else if (i == 2 && j == 1)
                        {
                            Console.Write(" ");
                        }
                        else if (i == 2 && j == 2)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                }
                #endregion
                #region KenarYıldızSayısıKullanıcıda
            //try
            //{
            //    //Tam tersi, kenar uzunluğu kullanıcı da,
            //    //Console.WriteLine("Karenin kenar uzunluğunu giriniz: ");
            //    //int n = Convert.ToInt16(Console.ReadLine());
            //    //int[,] stars = new int[n, n];
            //    //for (int i = 0; i < n; i++)
            //    //{
            //    //    {
            //    //        Console.WriteLine("");
            //    //    }
            //    //    for (int j = 0; j < n; j++)
            //    //    {
            //    //        if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
            //    //        {
            //    //            Console.Write("*");
            //    //        }
            //    //        else
            //    //        {
            //    //            Console.Write(" ");
            //    //        }
            //    //    }
            //    //} 
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Rakam işte rakam...");
            //}
            #endregion
            Console.ReadLine();
        }
    }
}
