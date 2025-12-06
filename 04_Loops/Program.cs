using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //Döngüler 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21

            //For(x;y;z)
            //x=>başlangıç değeri
            //y=>bitiş değeri
            //z=>artış/azalış değeri

            //int i;

            //for (i = 1; i <= 6; i++)
            //{
            //    Console.WriteLine("Hello World");
            //}
            //Console.Read();

            //---------------------------------------

            //int i;

            //for (i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();

            //---------------------------------------

            //int i;

            //for (i = 3; i <= 100; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Read();

            //---------------------------------------

            //Console.Write("Yazdırmak istediğiniz kadar sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    Console.WriteLine("Hello World");
            //}

            //Console.Read();

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i < 100; i++)
            //{
            //    if (i%5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.Read();

            //---------------------------------------

            //int totalValue = 0;

            //for (int i = 1; i <= 1000000; i++)
            //{
            //    totalValue += i;
            //}

            //Console.Write(totalValue);
            //Console.Read();

            //---------------------------------------

            //int totalValue = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-----------------------");
            //Console.Write(totalValue);
            //Console.Read();

            //---------------------------------------

            //int count = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);
            //Console.Read();

            //---------------------------------------

            //1-2-4-8-16-...

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + " Dakika sonundaki bakteri: " + bacterium);
            //}

            //Console.Read();

            #endregion

            #region While Döngüsü

            //int i = 1;

            //while (i <= 100)
            //{
            //    Console.WriteLine("Hello World");
            //    i++;
            //}

            //Console.Read();

            //---------------------------------------

            //int i = 1;

            //while (i <= 100)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //    i++;
            //}

            //Console.Read();

            //---------------------------------------

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("Toplam: " + sum);
            //Console.Read();

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen sayının basamakları toplamını hesaplayan kodu yazınız.

            //int number;
            //Console.Write("3 Basamakllı bir sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //int ones, tens, hundereds;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundereds = number / 100;

            //Console.WriteLine("Birler basamağı: " + ones);
            //Console.WriteLine("Birler basamağı: " + tens);
            //Console.WriteLine("Birler basamağı: " + hundereds);

            //Console.WriteLine("Basamaklar Toplamı: " + (ones + tens + hundereds));

            //Console.Read();


            #endregion
        }
    }
}
