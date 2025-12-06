using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            //Console.Read();

            #endregion

            #region Yan yana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Read();

            #endregion

            #region Alt alta ve yan yana 10'ar tane yıldız oluşturma

            //for(int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}
            //Console.Read();

            #endregion

            #region Dik Üçgen Oluşturma

            //for(int i = 1; i<=10; i++)
            //{
            //    for(int j =1; j<= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Read();

            #endregion

            #region Ters Dik Üçgen Oluşturma

            //for(int i = 10; i>= 1; i--)
            //{
            //    for(int j = 1; j<= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Read();

            #endregion

            #region Dik Üçgen ve ters Dik Üçgen Oluşturma

            //for(int i=1; i<=10; i++)
            //{
            //    for(int j=1; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int k=9; k>=1; k--)
            //{
            //    for(int m=1; m<=k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Read();


            #endregion

            #region Baklava Dilimi Oluşturma

            //int n = 5;

            ////Üst Kısmı
            //for (int i=1; i<=n; i++)
            //{
            //    for(int j= n-1; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(int k= 1; k <= 2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////Alt Kısmı
            //for (int i=n-1; i>=1; i--)
            //{
            //    for(int m=n-1; m>0; m--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(int p=1; p<= 2*i-1; p++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Read();

            #endregion

            #region Piramit Oluşturma

            //int n = 5;

            //for(int i=1; i<=n; i++)
            //{
            //    //Boşluklar
            //    for(int k = n-i; k > 0 ; k--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //Yıldızlar 
            //    for(int j = 1; j <= 2*i-1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Read();

            #endregion

            #region Ters Piramit

            //int n = 5;

            //for(int i= n; i>=1; i--)
            //{
            //    //Boşluklar
            //    for (int j = n-i; j>0; j-- )
            //    {
            //        Console.Write(" ");
            //    }

            //    //Yıldızlar
            //    for (int k= 1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Read();

            #endregion
        }
    }
}
