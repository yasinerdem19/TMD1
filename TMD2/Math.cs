using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMD2
{
    class Math
    {
        /// <summary>
        /// parametre olarak aldığı taban ve kuvvete bağlı olarak üst alır
        /// </summary>
        /// <param name="taban">taban</param>
        /// <param name="ust">üst</param>
        /// <returns>sonuç </returns>
        public static double UstAlma(double taban, double kuvvet)
        {
            double s = 1;
            for (int i = 1; i <= kuvvet; i++)
                s *= taban;
            return s;
        }

        /// <summary>
        /// bir sayının asal çarpanlarını verir
        /// </summary>
        /// <param name="n">sayı</param>
        /// <returns>asal çarpanlar dizisi</returns>
        public static string AsalCarpanlar(int n)
        {
            string carpanListesi = "";
            int i = 2;
            //asal çarpanları bulalım
            while (n >= i)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    carpanListesi += i.ToString() + ",";
                }
                else
                    i++;
            }
            carpanListesi = carpanListesi.Substring(0, carpanListesi.Length - 1);
            string[] carpanlar = carpanListesi.Split(",");
            string s = carpanlar[0];
            string y = s;
            for (i = 0; i < carpanlar.Length; i++)
            {
                if (!(s == carpanlar[i]))
                {
                    y = y + "," + carpanlar[i];
                    s = carpanlar[i];
                }
            }
            carpanlar = y.Split(',');
            int[] asalCarpanlar = new int[carpanlar.Length];
            for (i = 0; i < asalCarpanlar.Length; i++)
                asalCarpanlar[i] = Convert.ToInt32(carpanlar[i]);
            return "Tüm çarpanlar:  " + carpanListesi + System.Environment.NewLine
                + "Sayının çarpanları: " + y + System.Environment.NewLine;
        }
        public static int[] AsalCarpanlarSayi(int n)
        {
            string carpanListesi = "";
            int i = 2;
            //asal çarpanları bulalım
            while (n >= i)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    carpanListesi += i.ToString() + ",";
                }
                else
                    i++;
            }
            carpanListesi = carpanListesi.Substring(0, carpanListesi.Length - 1);
            string[] carpanlar = carpanListesi.Split(",");
            string s = carpanlar[0];
            string y = s;
            for (i = 0; i < carpanlar.Length; i++)
            {
                if (!(s == carpanlar[i]))
                {
                    y = y + "," + carpanlar[i];
                    s = carpanlar[i];
                }
            }
            carpanlar = y.Split(',');
            int[] asalCarpanlar = new int[carpanlar.Length];
            for (i = 0; i < asalCarpanlar.Length; i++)
                asalCarpanlar[i] = Convert.ToInt32(carpanlar[i]);
            return asalCarpanlar;
        }
        /// <summary>
        /// bir sayının asal çarpanlarının toplamını verir
        /// </summary>
        /// <param name="n">sayı</param>
        /// <returns>asal çarpanlarının toplamı</returns>
        public static int AsalCarpanlarinToplami(int n)
        {
            int[] asalCarpanlar = AsalCarpanlarSayi(n);
            int t = 0;
            for (int i = 0; i < asalCarpanlar.Length; i++)
                t += asalCarpanlar[i];
            return t;
        }
        /// <summary>
        /// bir sayının asal çarpanlarının çarpımını verir
        /// </summary>
        /// <param name="n">sayı</param>
        /// <returns>asal çarpanlarının çarpımı</returns>
        public static int AsalCarpanlarinCarpimi(int n)
        {
            int[] asalCarpanlar = AsalCarpanlarSayi(n);
            int t = 1;//başlangıç değeri sıfır olaamazzzz
            for (int i = 0; i < asalCarpanlar.Length; i++)
                t *= asalCarpanlar[i];
            return t;
        }
        /// <summary>
        /// parametre olarak aldığı 2 sayının en küçük ortak katını verir
        /// </summary>
        /// <param name="s1">sayı 1</param>
        /// <param name="s2">sayı 2</param>
        /// <returns>OKEK</returns>
        public static int OKEK(int s1, int s2)
        {
            int s = 1;
            while (s1 != 1 && s2 != 1)
            {
                int bol = 2;
                for (int i = 1; i < (s1 > s2 ? s1 : s2); i++)
                {
                    if (s1 % bol == 0 || s2 % bol == 0)
                    {
                        s *= bol;
                        if (s1 % bol == 0)
                            s1 = s1 / bol;
                        if (s2 % bol == 0)
                            s2 = s2 / bol;
                    }
                    else
                        bol++;
                }
            }
            return s;
        }
        /// <summary>
        /// parametre olarak aldığı 2 sayının en büyük ortak katını verir
        /// </summary>
        /// <param name="s1">sayı 1</param>
        /// <param name="s2">sayı 2</param>
        /// <returns>OKEK</returns>
        public static int OBEB(int s1, int s2)
        {
            int s = 1;
            int bol = 2;
            while (s1 != 1 && s2 != 1)
            {
                for (int i = 2; i < (s1 > s2 ? s1 : s2); i++)
                {
                    if (s1 % bol == 0 || s2 % bol == 0)
                    {
                        if (s1 % bol == 0 && s2 % bol == 0)
                            s *= bol;
                        if (s1 % bol == 0)
                            s1 /= bol;
                        if (s2 % bol == 0)
                            s2 /= bol;
                    }
                    else
                        bol++;
                }
            }
            return s;
        }
        /// <summary>
        /// parametre olarak verilen sayının faktöriyelini alır
        /// </summary>
        /// <param name="n">sayı</param>
        /// <returns>sayının faktöriyeli</returns>
        public static int Faktoriyel(int n)
        {
            if (n <= 1)
                return 1;
            int f = 1;
            for (int i = 2; i <= n; i++)
                f *= i;
            return f;
        }
        /// <summary>
        /// string ifadedeki virgülle ayrılmış sayısal değerlerden dizi oluşturur
        /// </summary>
        /// <param name="ifade">virgülle ayrılmış sayılardan oluşan bir ifade</param>
        /// <returns>sayısal dizi</returns>
        public int[] IfadeyiDiziyeCevir(string ifade)
        {
            string[] bolunmusIfade = ifade.Split(',');
            int n = bolunmusIfade.Length;
            //sayısal dizi
            int[] sayisalDizi = new int[n];
            //ayrıştırma
            for (int i = 0; i < n; i++)
            {
                sayisalDizi[i] = Convert.ToInt32(bolunmusIfade[i]);
                Console.WriteLine("dizi[{0}]={1}", i + 1, sayisalDizi[i]);
            }
            return sayisalDizi;
        }
        /// <summary>
        /// ikilik sistemdeki bir sayıyı onluk sisteme çevir
        /// </summary>
        /// <param name="ikilikSayi">ikilik sistemdeki sayı</param>
        /// <returns>onluk sistemdeki sayı</returns>
        public static int IkilikTabandanOnlukTabanaGec(string ikilikSayi)
        {
            //uzunluğu belirle
            int n = ikilikSayi.Length;
            //her bir basamağın dizide tutulması
            int[] basamaklar = new int[n];
            //onluk karşılığı
            int sayi = 0;
            bool kontrol = true;
            for (int i = 0; i < n; i++)
            {
                if (!(ikilikSayi[i] == '0' || ikilikSayi[i] == '1'))
                {
                    Console.WriteLine("\aHatali Giriş!");
                    kontrol = false;
                    break;
                }
                basamaklar[i] = (int)(ikilikSayi[i] - '0');//sıfırdan çıkarma mantığını anlamadım ama olsada olurmuş
            }
            //2'lik sistemden 10'luk sisteme geçiş
            if (kontrol)
            {
                for (int i = 0; i < n; i++)
                    sayi += (int)System.Math.Pow(2, n - 1 - i) * basamaklar[i];
            }
            return sayi;
        }
        /// <summary>
        /// girilen ifadedeki sesli harf sayısını verir, kaç sesli harf var
        /// </summary>
        /// <param name="ifade">cümle</param>
        /// <returns>cümledeki sesli harf sayısı</returns>
        public static int SesliHarfSayisiniBulma(string ifade)
        {
            int sesliHarf = 0;
            for (int i = 0; i < ifade.Length; i++)
            {
                //kontrol
                if (ifade[i] == 'a' || ifade[i] == 'A' ||
                    ifade[i] == 'e' || ifade[i] == 'E' ||
                    ifade[i] == 'ı' || ifade[i] == 'I' ||
                    ifade[i] == 'i' || ifade[i] == 'İ' ||
                    ifade[i] == 'o' || ifade[i] == 'O' ||
                    ifade[i] == 'ö' || ifade[i] == 'Ö' ||
                    ifade[i] == 'u' || ifade[i] == 'U' ||
                    ifade[i] == 'ü' || ifade[i] == 'Ü')
                    sesliHarf++;
            }
            return sesliHarf;
        }

    }
}
