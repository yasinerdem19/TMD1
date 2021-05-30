using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMD1
{
    public class Sayi
    {
        /// <summary>
        /// parametre olarak aldığı sayının tek/çift olduğunu kontrol eder.
        /// </summary>
        /// <param name="n">Sayi</param>
        /// <returns>tek sayıda true, değilse false</returns>
        public static bool TekMi(int n)
        {
            if (n % 2 == 1)
                return true;
            return false;
        }
        /// <summary>
        /// parametre olarak aldığı sayının tek/çift olduğunu kontrol eder.
        /// </summary>
        /// <param name="n">Sayi</param>
        /// <returns>çift sayıda true, değilse false</returns>
        public static bool CiftMi(int n)
        {
            if (n % 2 == 0)
                return true;
            return false;
        }
        /// <summary>
        /// parametre olarak aldığı sayının mutlak değerini döner
        /// </summary>
        /// <param name="n">Sayi</param>
        /// <returns>sayının mutlak değeri</returns>
        public static int MutlakDeger(int n)
        {
            if (n > 0)
                return n;
            else if (n < 0)
                return (-1 * n);
            else
                return 0;
        }
        /// <summary>
        /// parametre olarak aldığı sayının asal sayı olup olmadığını kontrol eder
        /// </summary>
        /// <param name="n">sayı</param>
        /// <returns>sayı asal ise doğru verir</returns>
        public static bool AsalMi(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("En Küçük Asal Sayı 2 'dir");
                return false;
            }

            bool kontrol = true;
            for (int i = 2; i < n; i++)

                if (n % i == 0)
                {
                    kontrol = false;
                    Console.WriteLine(i);
                    break;
                }
            return kontrol;
        }
        /// <summary>
        /// parametre olarak aldığı sayının rakamları toplamını döner
        /// </summary>
        /// <param name="n">sayı</param>
        /// <returns>rakamların toplamı</returns>
        public static int RakamlariToplami(int n)
        {
            int toplam = 0, rakam = 0;
            while (n>0)
            {
                rakam = n % 10;
                toplam += rakam;
                n = n / 10;
            }
            return toplam;
        }
        /// <summary>
        /// birden (sıfırdan) parametre olarak verilen sayıya kadar olan sayıların toplamını döngü ile hesaplayarak verir
        /// </summary>
        /// <param name="n">sayı</param>
        /// <returns>ssayıların toplamını for döngüsü ile hesaplayarak verir</returns>
        public static int NeKadarOlanSayilarinToplami(int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i++)
            {
                t += i;
            }
            return t;
        }
        /// <summary>
        /// birden (sıfırdan) parametre olarak verilen sayıya kadar olan sayıların toplamını formül ile hesaplayarak verir
        /// </summary>
        /// <param name="n">sayı</param>
        /// <returns>ssayıların toplamını formül ile hesaplayarak verir</returns>
        public static int NeKadarOlanSayilarinFormulIleToplami(int n)
        {
            return n*(n+1)/2;
        }
        public static int NeKadarOlanTekSayilarinToplami(int n)
        {
            int t = 0;
            for (int i =1; i <= n; i++)
            {
                if (i%2==1)
                    t += i;
            }
            return t;
        }
        public static int NeKadarOlanTekSayilarinToplamiAlternatifCozum(int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i += 2)
                t += i;
            return t;
        }
        public static int NeKadarOlanTekSayilarinFormulleToplami(int n)
        {
            n  ++;
            n = n / 2;
            return n * n;
        }
        public static int NeKadarOlanCiftSayilarinToplami(int n)
        {
            int t = 0;
            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                    t += i;
            }
            return t;
        }
        public static int NeKadarOlanCiftSayilarinToplamiAlternatifCozum(int n)
        {
            int t = 0;
            for (int i = 2; i <= n; i += 2)
                t += i;
            return t;
        }
        public static int NeKadarOlanCiftSayilarinFormulleToplami(int n)
        {
            n = n / 2;
            return n * (n+1);
        }








    }
}
