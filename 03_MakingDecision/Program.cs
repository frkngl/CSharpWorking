using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if Else Yapısı

            //Console.WriteLine("Lütefen şifrenizi giriniz:");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifreniz doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifreniz yanlış");
            //}
            //Console.ReadLine();

            //-------------------------------------------------------------

            //string country;
            //string capital;

            //Console.Write("Lütfen bir ülke ismi giriniz: ");
            //country = Console.ReadLine();

            //Console.Write("Lütfen başkent ismini giriniz: ");
            //capital = Console.ReadLine();

            //if (country == "türkiye" && capital == "ankara")
            //{
            //    Console.WriteLine("veriler doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("veriler hatalı");
            //}
            //Console.ReadLine();

            //-------------------------------------------------------------

            //int number;
            //Console.Write("Sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if(number == 5)
            //{
            //    Console.WriteLine("Girilen sayı doürudur.");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen sayı yanlıştır.");
            //}
            //Console.Read();

            //-------------------------------------------------------------

            //int exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.Write("1. Sınav notunuzu giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sınav notunuzu giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3. Sınav notunuzu giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //if (average > 0 & average <= 50)
            //{
            //    result = "Kaldı";
            //}
            //if (average > 50 & average <= 75)
            //{
            //    result = "Orta";
            //}
            //if (average > 75 & average <= 85)
            //{ 
            //    result = "İyi";
            //}
            //if (average > 85)
            //{
            //    result = "Çok iyi";
            //}

            //Console.WriteLine(result);
            //Console.Read();

            //-------------------------------------------------------------

            //string city;
            //Console.Write("Lütfen bir şehir ismi giriniz: ");
            //city = Console.ReadLine();

            //if (city == "ankara" | city == "adana" | city == "trabzon" | city == "bursa")
            //{
            //    Console.WriteLine("Girdiğiniz şehir bulunmaktadır.");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz şehir bulunmamaktadır.");
            //}

            //Console.Read();

            //-------------------------------------------------------------

            //string username;
            //Console.Write("Kullanıcı adınızı giriniz: ");
            //username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı adınız yanlış.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}
            //Console.Read();

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.Write(result);
            //Console.Read();

            //-------------------------------------------------------------

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("1. sayı ile 2. sayının bölümünden kalan: " + result);
            //Console.Read();

            //-------------------------------------------------------------

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Girilen sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen sayı tektir.");
            //}
            //Console.Read();

            #endregion

            #region Char değişkenler ile karar yapıları

            //char team;
            //Console.Write("Lütfen bir takım seçiniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'g' || team == 'G')
            //{
            //    Console.WriteLine("Galatasaray takımını seçtiniz.");
            //}
            //else if (team == 'f' || team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe takımını seçtiniz.");
            //}
            //else if (team == 'b' || team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş takımını seçtiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz takım seçimi yaptınız.");
            //}
            //Console.Read();

            #endregion

            #region Örnek Proje Uygulaması

            //Console.Write("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.Write("----------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- Salatalıklar");
            //Console.Write("----------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.WriteLine();
            //Console.Write("Detayını görmek istediğiniz menüyü seçiniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("----------Ana Yemekler Menüsü----------");
            //    Console.WriteLine("1- Kuru Fasulye");
            //    Console.WriteLine("2- Etli Yaprak Sarma");
            //    Console.WriteLine("3- Izgara Köfte");
            //    Console.WriteLine("4- Tavuk Sote");
            //    Console.WriteLine("5- Karnıyarık");
            //    Console.WriteLine("----------Ana Yemekler Menüsü----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("----------Çorba Menüsü----------");
            //    Console.WriteLine("1- Mercimek");
            //    Console.WriteLine("2- Yoğurtlu");
            //    Console.WriteLine("3- Yayla");
            //    Console.WriteLine("4- Domates");
            //    Console.WriteLine("5- Paça");
            //    Console.WriteLine("----------Çorba Menüsü----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("----------Pizza Menüsü----------");
            //    Console.WriteLine("1- Mozarella Peynirli");
            //    Console.WriteLine("2- Sucuklu");
            //    Console.WriteLine("3- Salamlı");
            //    Console.WriteLine("4- Mantarlı");
            //    Console.WriteLine("5- Karışık");
            //    Console.WriteLine("----------Pizza Menüsü----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("----------İçecekler Menüsü----------");
            //    Console.WriteLine("1- Fanta");
            //    Console.WriteLine("2- Coca-Cola");
            //    Console.WriteLine("3- Pepsi");
            //    Console.WriteLine("4- Fruko");
            //    Console.WriteLine("5- Su");
            //    Console.WriteLine("----------İçecekler Menüsü----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("----------Tatlı Menüsü----------");
            //    Console.WriteLine("1- Kemal Paşa");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Sütlaç");
            //    Console.WriteLine("4- Cheesecake");
            //    Console.WriteLine("5- Brownili Pasta");
            //    Console.WriteLine("----------Tatlı Menüsü----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "6")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("----------Salatalık Menüsü----------");
            //    Console.WriteLine("1- Marul");
            //    Console.WriteLine("2- Zeytinli");
            //    Console.WriteLine("3- Domatesli");
            //    Console.WriteLine("4- Limonlu");
            //    Console.WriteLine("5- Sirkeli");
            //    Console.WriteLine("----------Salatalık Menüsü----------");
            //    Console.WriteLine();
            //}

            //Console.Read();

            #endregion

        }
    }
}
