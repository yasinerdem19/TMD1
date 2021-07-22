using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMD2
{
    class Programs
    {
        public static void Program1()
        {
            double s1 = Convert.ToDouble(Console.ReadLine());
            double s2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}^{1}={2}", s1, s2, Math.UstAlma(s1, s2));

        }
        public static void Program2()
        {
            Console.WriteLine(Math.AsalCarpanlar(60));
        }
        public static void Program3()
        {
            Console.WriteLine("asal çarpanlarını görmek istediğiniz sayıyı giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} sayısının asal çarpanları listesi aşağıdadır:", n);
            int[] asalCarpanlar = Math.AsalCarpanlarSayi(n);
            for (int i = 0; i < asalCarpanlar.Length; i++)
                Console.WriteLine(asalCarpanlar[i]);
        }
        public static void Program4()
        {
            Console.WriteLine("asal çarpanlarının toplamını görmek istediğiniz sayıyı giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} sayısının asal çarpanları toplamı={1}", n, Math.AsalCarpanlarinToplami(n));
        }
        public static void Program5()
        {
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("OKEK ({0},{1})={2}", s1, s2, Math.OKEK((int)s1, (int)s2));
        }
        public static void Program6()
        {
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("OBEB ({0},{1})={2}", s1, s2, Math.OBEB((int)s1, (int)s2));
        }
        public static void Program7()
        {
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}! = {1})", k, Math.Faktoriyel(k));
        }
        public static void Program8()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int t = 0;

            for (int i = m; i <= n; i++)
            {
                t += Math.Faktoriyel(i);
                Console.WriteLine("{0}! = {1}", i, Math.Faktoriyel(i));
            }
            Console.WriteLine("Ortalama: {0:F2}", (double)t / (n - m + 1));
        }
        public static void Program9()
        {
            Math d = new Math();
            int[] dizi = d.IfadeyiDiziyeCevir(Console.ReadLine());
        }
        public static void Program10()//9 un aynısı
        {
            int[] dizi = new Math().IfadeyiDiziyeCevir(Console.ReadLine());
        }
        public static void Program11()
        {
            string ikilikSayi = Console.ReadLine();
            Console.WriteLine("({0}) ikilik sayı = {1}", ikilikSayi, Math.IkilikTabandanOnlukTabanaGec(ikilikSayi));
        }
        public static void Program12()
        {
            string cumle = Console.ReadLine();
            Console.WriteLine("{0} ifadesinde {1} sesli harf var", cumle, Math.SesliHarfSayisiniBulma(cumle));
        }



        
    }
}

