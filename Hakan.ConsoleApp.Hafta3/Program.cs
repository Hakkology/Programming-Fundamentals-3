using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.Login_Register
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //ileride blackliste başka isimler ekleme ihtimaline karşın
                string blacklist = "feyza";
                Console.WriteLine("Merhabalar, kanalımıza hoşgeldiniz. Kayıt yapmak için lütfen Kullanıcı adı ve Şifrenizi belirleyiniz.");
                Console.Write("Lütfen kullanıcı adınızı yazınız: ");
                string user1 = Console.ReadLine();
                //bu adıma önceden gerek yoktu, kullanıcı adı neden küçük-büyük girdiye hassas? Çözüldü, ama sor.
                string user = user1.ToLower();
                Console.Write("Lütfen şifrenizi yazınız: ");
                string pass1 = Console.ReadLine();
                string pass = pass1.ToLower();
                if (user.ToLower() == blacklist)
                {
                    Console.WriteLine($"{user} kara listede olduğu için girişiniz bloklanmıştır. İyi günler.");
                    Console.ReadLine();
                }
                else
                {
                    int deneme = 2;
                    Console.WriteLine($"{user} adlı hesabınız oluşturulmuştur. İyi günlerde kullanın.");
                    Console.ReadLine();

                    //for döngüsü için giriş sayısı 3ü geçmemeli.
                    for (int giriş = 0; giriş < 3; giriş++)
                    {
                        Console.WriteLine("Lütfen kanalımıza hesap bilgileriniz ile giriş yapınız.");
                        Console.Write("Kullanıcı adınızı giriniz: ");
                        string username = Console.ReadLine();
                        Console.Write("Şifrenizi giriniz: ");
                        string password = Console.ReadLine();
                        if (username.ToLower() == user && password.ToLower() == pass)
                        {
                            //istenen diğer parametreler, adı, soyadı, tc kimlik no
                            Console.WriteLine("Kanalımıza hoşgeldiniz.");
                            Console.Write("Kaydınızı tamamlayabilmek için lütfen isminizi giriniz: ");
                            string name = Console.ReadLine();
                            Console.Write("Lütfen soyadınızı giriniz: ");
                            string surname = Console.ReadLine();
                            Console.Write("Lütfen Kimlik numaranızı giriniz: ");
                            string IDNumber = Console.ReadLine();
                            int count = (int)IDNumber.Length;
                            //tc kimlik no tekrar sorulmalı
                            while (count != 11)
                            {
                                Console.Write("Lütfen 11 haneli Kimlik numaranızı giriniz: ");
                                IDNumber = Console.ReadLine();
                                count = IDNumber.Length;
                            }
                            Console.WriteLine("Kaydınız başarıyla tamamlanmıştır. İyi eğlenceler.");
                            Console.ReadLine();
                            break;
                        }
                        else if (deneme == 1)
                        {
                            Console.WriteLine("Hesabınız yanlış girişten dolayı bloklanmıştır. İyi günler.");
                        }
                        else
                        {
                            deneme = (2 - giriş);
                            Console.WriteLine($"Yanlış bir giriş yaptınız, tekrar denemek için herhangi bir tuşa basınız. Bloklanmadan önce {deneme} denemeniz kaldı.");
                        }
                        Console.ReadLine();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Beklenmedik bir hata oluştu.");
            }
        }
    }
}
