using System;

namespace TMD1
{
    class Donguler
    {
        public static void Dongu1()
        {
            for (int i = 0; i >= -100; i--)
            {
                Console.WriteLine("{0} -> {1}", i, i * i);
            }
        }
        //sayıları beşer arttır
        public static void Dongu2()
        {
            for (int i = 0; i <= 100; i += 5)
            {
                Console.WriteLine("{0} -> {1}", i, i * i);
            }
        }
        //consolda hizalı yazdır
        public static void Dongu3()
        {
            for (int i = 33; i <= 100; i += 5)
            {
                Console.WriteLine("{0,3} -> {1,7}", i, i * i);
            }
        }
        public static void Dongu4()
        {
            int tekToplam = 0, ciftToplam = 0;
            Console.WriteLine("Limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tek Sayılar");
            for (int i = 1; i < limit; i += 2)
            {
                Console.Write("{0,5}", i);
                tekToplam += i;//tekToplam=tekToplam+i
            }
            Console.WriteLine("\n\nÇift Sayılar");
            for (int i = 2; i < limit; i += 2)
            {
                Console.Write("{0,5}", i);
                ciftToplam += i;//tekToplam=tekToplam+i
            }
            Console.WriteLine("\n\nTek Toplam: {0,5}\nCift Toplam: {1,5}", tekToplam, ciftToplam);
        }
        public static void Dongu5()
        {
            int sayac = 0;
            for (int i = 994; i >= 0; i -= 5)
            {
                Console.Write("{0,5}", i);
                sayac++;
            }
            Console.WriteLine("\n\nEleman Sayısı : {0}", sayac);
        }
        public static void Dongu6()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0,5}x\t{1,5}={2,5}", i, j, i * j);
                }
                Console.WriteLine("\n\n----------------------\n\n");
            }
        }
        public static void Dongu7()
        {
            //string[] asdfasdfasdf = new int[6];
            //string[] asdfasdfasdf = new int[] { 1, 2, 32, 651, 151, 12 };
            //string[] asdfasdfasdf = { 1, 2, 32, 651, 151, 12 };

            //1D array declaration
            int[] array = new int[5];

            //get length of the array
            int n = array.Length;

            //random number generator for the array
            for (int i = 0; i < n; i++)
            {
                array[i] = new Random().Next(1, 50);
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }

        public static void Dongu8()
        {
            //declaration of the number array
            int[] number = new int[6];

            //declaration of the square array
            int[] square = new int[6];

            //get the length of the array
            int n = number.GetLength(0);

            //assigment of the random number
            //calculation of the square
            for (int i = 0; i < n; i++)
            {
                number[i] = new Random().Next(1, 9);
                square[i] = number[i] * number[i];
                Console.WriteLine("{0} karesi = {1}", number[i], square[i]);
            }
            Console.ReadLine();
        }
        /// <summary>
        /// rastgele sayılardan bir dizi olusturur ve dizinin en küçük/büyük elemanlarını yazar
        /// </summary>
        public static void Dongu9()
        {
            Console.WriteLine("n değerini giriniz");
            int limit = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                sayilar[i] = new Random().Next(1, 100);
                Console.Write("{0,5}", sayilar[i]);
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("\nDizinin En Büyük Elemanı:{0}", EnBuyuk(sayilar));
            Console.WriteLine("\nDizinin En Küçük Elemanı:{0}", EnKucuk(sayilar));
        }
        /// <summary>
        /// dizinin en büyük elemanını bulur ve yazar
        /// </summary>
        /// <param name="dizi">dizi</param>
        /// <returns>dizinin en büyük elemanı(aynı sayılar varsa ilk eleman)</returns>
        public static int EnBuyuk(int[] dizi)
        {
            int eb = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > eb)
                {
                    eb = dizi[i];
                }
            }
            return eb;
        }
        /// <summary>
        /// dizinin en küçük elemanını bulur ve yazar
        /// </summary>
        /// <param name="dizi">dizi</param>
        /// <returns>dizinin en küçük elemanı(aynı sayılar varsa ilk eleman)</returns>
        public static int EnKucuk(int[] dizi)
        {
            int ek = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < ek)
                {
                    ek = dizi[i];
                }
            }
            return ek;
        }


        public static void Dongu10()
        {
            //Console.WriteLine("n değerini giriniz");
            //int limit = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[7];
            for (int i = 0; i < 7; i++)
            {
                sayilar[i] = new Random().Next(1, 9999);
                Console.WriteLine("{0,5}", sayilar[i]);
            }
            Console.WriteLine("\n------------------------");
            Console.WriteLine("\nDizinin En Büyük Elemanı:{0}", EnBuyuk(sayilar));
            Console.WriteLine("\nDizinin En Küçük Elemanı:{0}", EnKucuk(sayilar));
        }
        /// <summary>
        /// aritmetik ortalamayı kendi içinde dizi oluşturup aritmetik orlamasını getirir
        /// </summary>



        public static void Dongu11()
        {
            Console.WriteLine("n değerini giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[n];
            int toplam = 0;
            for (int i = 0; i < n; i++)
            {
                sayilar[i] = new Random().Next(1, 9999);
                Console.WriteLine("{0,5}", sayilar[i]);
                toplam = sayilar[i] + toplam;
            }
            Console.WriteLine("{0}", toplam / n);
        }





        public int[] DiziOlustur(int limit)
        {
            int[] sayilar = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                sayilar[i] = new Random().Next(1, 100);
                Console.Write("{0,5}", sayilar[i]);
            }
            return sayilar;
        }



        /// <summary>
        /// parametre olarak aldığı dizinin aritmetik orlalamasını döner
        /// </summary>
        /// <param name="X">dizi</param>
        /// <returns>aritmetik ortalama</returns>
        public static double AritmetikOrtalama(int[] ortalama)
        {
            double toplam = 0;
            for (int i = 0; i < ortalama.Length; i++)
            {
                toplam += ortalama[i];
            }
            return toplam / (ortalama.Length);
        }


        public static void Dongu12()
        {
            Console.WriteLine("n değerini giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] X = new Donguler().DiziOlustur(n);
            Console.WriteLine("\nDizinin Aritmetik Ortalaması: {0:F2}", Donguler.AritmetikOrtalama(X));
        }
        /// <summary>
        /// parametre olarak aldığı dizinin standart sapmasını hesaplar ve döner
        /// </summary>
        /// <param name="X">Dizi</param>
        /// <returns>Standart sapma</returns>
        public static double StandartSapma(int[] X)
        {
            double aritmetikOrtalama = AritmetikOrtalama(X);
            double t = 0, f = 0;
            double std = 0;
            for (int i = 0; i < X.Length; i++)
            {
                f = X[i] - aritmetikOrtalama;
                t += Math.Pow(f, 2);
            }
            ///kısaltma yapılabilir  return Math.Sqrt(t / (X.Length - 1));
            std = t / (X.Length - 1);
            std = Math.Sqrt(std);
            return std;
        }
        public static void Dongu13()
        {
            Console.WriteLine("n değerini giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] X = new Donguler().DiziOlustur(n);
            Console.WriteLine("\nDizinin Standart Sapması: {0:F2}", Donguler.StandartSapma(X));
        }
        /// <summary>
        /// bir dizideki tek sayıların sayısını verir
        /// </summary>
        /// <param name="X">dizi</param>
        /// <returns>kaç tane tek sayı var?</returns>
        public int TekSayilarinSayisi(int[] X)
        {
            int tekSayilarinSayisi = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 1)
                    tekSayilarinSayisi++;
            }
            return tekSayilarinSayisi;
        }
        /// <summary>
        /// bir dizideki cift sayıların sayısını verir
        /// </summary>
        /// <param name="X">dizi</param>
        /// <returns>kaç tane cift sayı var?</returns>
        public int CiftSayilarinSayisi(int[] X)
        {
            int ciftSayilarinSayisi = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i]%2 == 0)
                    ciftSayilarinSayisi++;
            }
            return ciftSayilarinSayisi;
        }
        /// <summary>
        /// bir dizideki tek sayılardan yeni bir dizi olusturur
        /// </summary>
        /// <param name="X">dizi</param>
        /// <returns>dizideki tek sayılardan oluşan dizi</returns>
        public int[] TekDiziOlustur(int[] X)
        {
            int[] tekDizi = new int[TekSayilarinSayisi(X)];
            int y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i]%2 == 1)
                {
                    tekDizi[y] = X[i];
                    y++;
                }
            }
            return tekDizi;
        }
        public int[] CiftDiziOlustur(int[] X)
        {
            int[] ciftDizi = new int[CiftSayilarinSayisi(X)];
            int y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                {
                    ciftDizi[y] = X[i];
                    y++;
                }
            }
            return ciftDizi;
        }
        /// <summary>
        /// parametre olarak aldığı diziyi ekrana yazdırır
        /// </summary>
        /// <param name="X">dizi</param>
        public static void Yazdir(int[] X)
        {
            Console.WriteLine("");
            for (int i = 0; i < X.Length; i++)
                Console.Write("{0,4}", X[i]);
            Console.WriteLine("");
        }
        /// <summary>
        /// parametre olarak alınan bir dizideki tek ve çift sayıları ayırır ve sayılarını ve ayrı ayrı dizilerini yazdırır
        /// </summary>
        public static void Dongu14()
        {
            Console.WriteLine("n değerini giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] X = new Donguler().DiziOlustur(n);
            Donguler dizi = new Donguler();
            int[] tekSayilarinDizisi = dizi.TekDiziOlustur(X);
            Console.WriteLine("\n");
            Donguler.Yazdir(tekSayilarinDizisi);
            Console.WriteLine("\nTek Sayıların Sayisi {0,5}", dizi.TekSayilarinSayisi(X));
            int[] ciftSayilarinDizisi = dizi.CiftDiziOlustur(X);
            Console.WriteLine("\n");
            Donguler.Yazdir(ciftSayilarinDizisi);
            Console.WriteLine("\nÇift Sayıların Sayisi {0,5}", dizi.CiftSayilarinSayisi(X));
        }
    }
}