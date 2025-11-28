using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                      
namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Metodları
            //Console.WriteLine("Hello World");//İmleci en sağa getirtmeye işe yarar.
            //Console.Write("Hello World"); //İmleci satır sonuna getirtmez.

            //Console.WriteLine("***** Kategoriler *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalıklar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Kategoriler *****");

            //Console.Read(); //Konsol ekranının hemen kapanmaması için kullanılır.
            #endregion

            #region String Değişken
            //string name;
            //name = "Furkan";
            //Console.Write(name);

            //string customerName; //Değişken isimlendirmelerde bu şekilde adlandırmalara camelcase denir.
            //string customerSurname;
            //string customerPhoneNumber;
            //string customerEmail, customerDistrict, customerCity;

            //customerName = "Furkan";
            //customerSurname = "GÜL";
            //customerPhoneNumber = "+905555555555";
            //customerEmail = "furkangul.dev@gmail.com";
            //customerDistrict = "Turhal";
            //customerCity = "Tokat";

            //Console.WriteLine("***** Rezervasyon *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhoneNumber);
            //Console.WriteLine("E-Posta: " + customerEmail);
            //Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            //Console.WriteLine("----------------------------------------------");

            //customerName = "Ahmet";
            //customerSurname = "TOSUN";
            //customerPhoneNumber = "+905555555555";
            //customerEmail = "ahmettosun@gmail.com";
            //customerDistrict = "Kartal";
            //customerCity = "İstanbul";

            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhoneNumber);
            //Console.WriteLine("E-Posta: " + customerEmail);
            //Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            //Console.WriteLine("----------------------------------------------");

            //customerName = "Alper";
            //customerSurname = "KILIÇ";
            //customerPhoneNumber = "+905555555555";
            //customerEmail = "alperkilic@gmail.com";
            //customerDistrict = "Turhal";
            //customerCity = "Tokat";

            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhoneNumber);
            //Console.WriteLine("E-Posta: " + customerEmail);
            //Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            //Console.WriteLine("----------------------------------------------");

            //customerName = "Semih";
            //customerSurname = "ÇAĞLAYAN";
            //customerPhoneNumber = "+905555555555";
            //customerEmail = "semihcaglayan@gmail.com";
            //customerDistrict = "Turhal";
            //customerCity = "Tokat";

            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhoneNumber);
            //Console.WriteLine("E-Posta: " + customerEmail);
            //Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            //Console.WriteLine("----------------------------------------------");
            //customerName = "Alparslan";
            //customerSurname = "SEVİM";
            //customerPhoneNumber = "+905555555555";
            //customerEmail = "alparslansevim@gmail.com";
            //customerDistrict = "Turhal";
            //customerCity = "Tokat";

            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhoneNumber);
            //Console.WriteLine("E-Posta: " + customerEmail);
            //Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            //Console.WriteLine("----------------------------------------------");

            //Console.Read();
            #endregion

            #region Integer Değişken
            //int
            //int number = 25;
            //Console.Write(number);

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;

            //Console.WriteLine("***** Menü Fiyat Listesi *****");
            //Console.WriteLine("Hamburger: " + hamburgerPrice + " TL");
            //Console.WriteLine("Kola: " + cokePrice + " TL");
            //Console.WriteLine("Su: " + waterPrice + " TL");
            //Console.WriteLine("Patates Kızartması: " + friesPrice + " TL");
            //Console.WriteLine("Pizza: " + pizzaPrice + " TL");
            //Console.WriteLine("Limonata: " + lemonadePrice + " TL");

            //int hamburgerCount = 2;
            //int cokeCount = 3;
            //int waterCount = 1;
            //int friesCount = 1;
            //int pizzaCount = 0;
            //int lemonadeCount = 2;

            //int totalHamburgerCount = hamburgerPrice * hamburgerCount;
            //int totalCokeCount = cokePrice * cokeCount;
            //int totalWaterCount = waterPrice * waterCount;
            //int totalFriesCount = friesPrice * friesCount;
            //int totalPizzaCount = pizzaPrice * pizzaCount;
            //int totalLemonadeCount = lemonadePrice * lemonadeCount;

            //Console.WriteLine();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine();
            //Console.WriteLine("***** Hesap *****");
            //Console.WriteLine("Hamburger Tutarı: " + totalHamburgerCount);
            //Console.WriteLine("Kola Tutarı: " + totalCokeCount);
            //Console.WriteLine("Su Tutarı: " + totalWaterCount);
            //Console.WriteLine("Patates Kızartması Tutarı: " + totalFriesCount);
            //Console.WriteLine("Pizza Tutarı: " + totalPizzaCount);
            //Console.WriteLine("Limonata Tutarı: " + totalLemonadeCount);
            //Console.WriteLine();

            //int totalPrice = totalHamburgerCount + totalCokeCount + totalWaterCount + totalFriesCount + totalPizzaCount + totalLemonadeCount;

            //Console.WriteLine("Toplam Ödenecek Tutar:" + totalPrice + " TL");
            //Console.Read();
            #endregion
        }
    }
}
