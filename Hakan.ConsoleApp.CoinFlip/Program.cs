using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.CoinToss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yazı = 0;
            int tura = 0;
            bool devam = true;

            Console.WriteLine("Dünyanın en güvenilir para atma makinesine hoşgeldiniz. Para atmak için herhangi bir tuşa basın:");
            Console.ReadLine();
            while (devam)
            {
                Console.WriteLine($"Şu ana kadar {yazı} kez yazı {tura} kez tura attınız.");
                Random para = new Random();
                //Next(0,2) %50 veriyor, olmazsa ?
                //Önemli soru, kullanıcıya %100 güvenli bir para atma makinesi olduğunu nasıl ispatlarım ?
                int sonuc = para.Next(0, 5);
                if (sonuc == 0 || sonuc == 1)
                {
                    Console.WriteLine("Paranız yazı geldi.");
                    yazı++;
                }
                else
                {
                    Console.WriteLine("Paranız tura geldi.");
                    tura++;
                }
                Console.WriteLine("Tekrar para atmak istiyor musunuz? (E/H): ");
                if (Console.ReadKey().Key == ConsoleKey.E)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Dünyanın en güvenilir para atma makinesini kullandığınız için teşekkürler.");
                    devam = false;
                }
            }
            Console.ReadLine();
        }
    }
}
