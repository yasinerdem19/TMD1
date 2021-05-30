using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMD1
{
    class SayiFonc
    {
        public static void SayiKod1()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            n = (Sayi.MutlakDeger(n));
            if (Sayi.TekMi(n))
                Console.WriteLine("Girilen sayi tek {0}", n);
            else if (Sayi.CiftMi(n))
                Console.WriteLine("Girilen sayi çift {0}", n);
            else
                Console.WriteLine("Girilen sayi ???? {0}", n);
        }


        public static void SayiKod2()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", Sayi.AsalMi(n) ? "Asal Sayıdır " : "Asal Sayı Değil");
        }
        public static void SayiKod3()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} sayısının rakamları toplamı (formül ile) =  {1}", n, Sayi.RakamlariToplami(n));
        }

        public static void SayiKod4()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birden {0}'e kadar olan sayıların toplamı = {1,5}",
                    n, Sayi.NeKadarOlanSayilarinFormulIleToplami(n));
            Console.WriteLine("Birden {0}'e kadar olan sayıların toplamı(Formül ile) = {1,5}",
                n, Sayi.NeKadarOlanSayilarinFormulIleToplami(n));
        }
        public static void SayiKod5()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", Sayi.NeKadarOlanTekSayilarinToplami(n));
            Console.WriteLine("{0}", Sayi.NeKadarOlanTekSayilarinToplamiAlternatifCozum(n));
            Console.WriteLine("{0}", Sayi.NeKadarOlanTekSayilarinFormulleToplami(n));
        }
        public static void SayiKod6()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", Sayi.NeKadarOlanCiftSayilarinToplami(n));
            Console.WriteLine("{0}", Sayi.NeKadarOlanCiftSayilarinToplamiAlternatifCozum(n));
            Console.WriteLine("{0}", Sayi.NeKadarOlanCiftSayilarinFormulleToplami(n));
        }
        public static void SayiKod7()
        {
            //farklı problemlerde eski metotları kullanalım
            int t1 = Sayi.NeKadarOlanCiftSayilarinToplami(80);
            int t2 = Sayi.NeKadarOlanCiftSayilarinToplami(48);
            Console.WriteLine("{0,5}-{1,5}={2,5}", t1, t2, t1 - t2);
        }
        public static void SayiKod8()
        {
            const double pi = 3.14;
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2*{0:F2} * {1:F2} = {2:F8}", pi, r, 2 * pi * r);
        }
        public static void SayiKod9()
        {
            // farklı bir yöntem  (SayiKod8'e alternatif)
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2*{0:F2} * {1:F2} = {2:F8}", Cember.pi, r, Cember.Cevresi(r));
        }
        public static void SayiKod10()
        {
            // Dairenin alanı
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:F2} * {1:F2} * {1:F2} = {2:F8}", Cember.pi, r, Daire.Alani(r));
        }
        public static void SayiKod11()
        {
            // Dairenin alanı
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} Yarıçaplı dairenin alanı = {1:F2} 'dir", r, Daire.Alani(r));
        }
        public static void SayiKod12()
        {
            // Dairenin alanı (açı ile)
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} Yarıçaplı dairenin 60 derecelik " +
                "açıya sahip alanı = {2:F2} 'dir",
                r, r, Daire.AlaniHesapla(r, 60));
        }
        public static void SayiKod13()
        {
            // Dairenin alanı (üs formülü ile)
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Alan = {0}",Daire.AlaniHesaplaFormul(r));
        }

    }
}
