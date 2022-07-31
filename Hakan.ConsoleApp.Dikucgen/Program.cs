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
            //kenar uzunluğu 6 yıldız olan üçgen
            #region DikÜçgen6kenar
            //int[,] stars = new int[6, 6];
            //for (int i = 0; i < stars.GetLength(0); i++)
            //{
            //    Console.WriteLine("");
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //} 
            #endregion
            //kenar uzunluğu yıldız sayısı olursa ve kullanıcıdan istenirse
            #region DikÜçgenKenarKullanıcıdan
            try
            {
                Console.WriteLine("Lütfen dik kenar yıldız sayısını giriniz: ");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                }
                #endregion
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Rakam gir rakam. Patladık.");
            }
        }
    }
}
