using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMD3
{
    public class GeneralFonctions
    {
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris1()
        {
            Console.WriteLine("Matrisin satır sayısını giriniz");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Matrisin sütun sayısını giriniz");
            int column = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Matrisin minimum sayısı için değer giriniz");
            int minn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Matrisin maksimum sayısı için değer  giriniz");
            int maxn = Convert.ToInt32(Console.ReadLine());

            int[,] X = MatrisOlustur(row, column, minn, maxn);
            MatrisYazdir(X);
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris2()
        {
            int[,] X = SifirMatrisiOlustur(3, 3);
            MatrisYazdir(X);
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris3()
        {
            int[,] X = BirlerMatrisiOlustur(4, 5);
            MatrisYazdir(X);
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris4()
        {
            int[,] X = KosegenMatrisOlustur(4, 5, 9);
            MatrisYazdir(X);
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris5()
        {
            int[,] X = SkalerMatrisOlustur(4, 4);
            MatrisYazdir(X);
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris6()
        {
            int[,] X = BirlerMatrisiOlustur(3, 3);//KosegenMatrisOlustur da çağırabilirsin
            MatrisYazdir(X);
            Console.WriteLine("{0}",
            KareMatrisMi(X) ? "Kare Matris" : "Kare Matris Değil");
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris7()
        {
            int[,] X = BirimMatrisOlustur(4);
            MatrisYazdir(X);
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris8()
        {
            int[,] X = MatrisOlustur(5, 7, 1, 99);//diğer matrislerle deneyebilirsin
            Console.WriteLine("{0}", BirimMatrisMi(X) ? "Birim Matris" : "Birim Matris Değil!");
            MatrisYazdir(X);
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris9()
        {
            int[,] X = KosegenMatrisOlustur(5);//diğer matrislerle deneyebilirsin
            MatrisYazdir(X);
            int[] D = GeneralFonctions.DiyagonalElemanlarinListesi(X);
            MatrisYazdir(D);
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris10()
        {
            int[,] X = KosegenMatrisOlustur(7);//diğer matrislerle deneyebilirsin/ köşegen olmazsa sonuç hata mesajı
            MatrisYazdir(X);
            int[] D = GeneralFonctions.DiyagonalElemanlarinListesi(X);
            MatrisYazdir(D);
            Console.WriteLine("Matrisin İzi: {0}", GeneralFonctions.Izi(X));
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris11()
        {
            int[,] X = MatrisOlustur(3, 5);//diğer matrislerle deneyebilirsin
            MatrisYazdir(X);
            int[,] T = Transpoz(X);
            MatrisYazdir(T);
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris12()
        {
            int[,] X = MatrisOlustur(4, 3);//diğer matrislerle deneyebilirsin
            MatrisYazdir(X);
            int[,] T = YenidenSekillendir(X, 1, 12);
            MatrisYazdir(T);
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris13()
        {
            int[,] X = SifirMatrisiOlustur(3, 4);
            int[,] Y = SifirMatrisiOlustur(7, 4);
            MatrisYazdir(X);
            MatrisYazdir(Y);
            if (GeneralFonctions.EsitMi(X, Y))
            {
                Console.WriteLine("Matrisler Eşit");
            }
            else
                GeneralFonctions.YazdirHata("Matrisler Eşit Değil");

            //Console.WriteLine("{0}",
            //    GeneralFonctions.EsitMi(X, Y) ? "Matrisler Eşit" : "Matrisler Eşit Değil");
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris14()
        {
            int[,] X = MatrisOlustur(3, 3);
            MatrisYazdir(X);
            Console.WriteLine("|X| = {0}", GeneralFonctions.Determinant(X));
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris15()
        {
            int[,] X = MatrisOlustur(3, 3);//parantez içi boş olursa varsayılan 3*3
            MatrisYazdir(X);
            ScalerCarpim(2, X);
            MatrisYazdir(X);
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris16()
        {
            int[,] X = MatrisOlustur(2, 2);//parantez içi boş olursa varsayılan 3*3
            MatrisYazdir(X);
            Console.WriteLine("Yukarıdaki matrisin elemanlarının toplamı:  {0} ", ElemanlarinToplami(X));
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris17()
        {
            int[,] X = SimetrikMatrisOlustur(8, 11, 568);
            MatrisYazdir(X);
            Console.WriteLine("{0}", SimetrikMi(X) ? "Simetrik" : "Simetrik Değil!");

            X = MatrisOlustur(4, 6);
            MatrisYazdir(X);
            Console.WriteLine("{0}", SimetrikMi(X) ? "Simetrik" : "Simetrik Değil!");

            X = KosegenMatrisOlustur(7);
            MatrisYazdir(X);
            Console.WriteLine("{0}", SimetrikMi(X) ? "Simetrik" : "Simetrik Değil!");
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris18()
        {
            int[,] X = MatrisOlustur(3, 3, 1, 3);
            MatrisYazdir(X);
            Console.WriteLine("{0}", KosegenMatrisMi(X) ? "Köşegen Matristir" : "Köşegen Matris Değildir");

            X = KosegenMatrisOlustur(3, 1, 3);
            MatrisYazdir(X);
            Console.WriteLine("{0}", KosegenMatrisMi(X) ? "Köşegen Matristir" : "Köşegen Matris Değildir");
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris19()
        {
            int[,] X = UstUcgenMatrisOlustur(3, 2, 33);
            MatrisYazdir(X);
            X = UstUcgenMatrisOlustur(5, -7, 7);
            MatrisYazdir(X);
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris20()
        {
            int[,] X = AltUcgenMatrisOlustur(3, 2, 33);
            MatrisYazdir(X);
            X = AltUcgenMatrisOlustur(5, -7, 7);
            MatrisYazdir(X);
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris21()
        {
            int[,] X = MatrisOlustur(3, 3, 1, 3);
            MatrisYazdir(X);
            Console.WriteLine("{0}", UstUcgenMatrisMi(X) ? "Üst Üçgen Matristir" : "Üst Üçgen Matris Değildir");

            X = UstUcgenMatrisOlustur();
            MatrisYazdir(X);
            Console.WriteLine("{0}", UstUcgenMatrisMi(X) ? "Üst Üçgen Matristir" : "Üst Üçgen Matris Değildir");
        }
        /// <summary>
        /// Tüm Methodları aynı classta yazmak için bu yöntemi kullandım. Program.cs'den matrisX'i çağırarak tüm kodlar kontrol edilebilir
        /// </summary>
        public static void Matris22()
        {
            int[,] X = MatrisOlustur(4, 4, 1, 3);
            MatrisYazdir(X);
            Console.WriteLine("{0}", AltUcgenMatrisMi(X) ? "Alt Üçgen Matristir" : "Alt Üçgen Matris Değildir");

            X = AltUcgenMatrisOlustur(5, -5, 5);
            MatrisYazdir(X);
            Console.WriteLine("{0}", AltUcgenMatrisMi(X) ? "Alt Üçgen Matristir" : "Alt Üçgen Matris Değildir");
        }











































        ////
        /// <summary>
        /// string ifadeyi renklendirir ve windows sesi ile uyarı mesajı verir
        /// </summary>
        /// <remarks>herhangi bir string ifade</remarks>
        public static void YazdirHata(string mesaj)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\a\n{0}\n\a", mesaj);
            Console.ResetColor();
        }
        /// <summary>
        /// matris oluşturur
        /// </summary>
        /// <param name="row">satır sayısı</param>
        /// <param name="column">sütun sayısı</param>
        /// <param name="minn">min değer</param>
        /// <param name="maxn">max değer</param>
        /// <returns></returns>
        public static int[,] MatrisOlustur(int row = 3, int column = 3, int minn = 1, int maxn = 9)
        {
            int[,] X = new int[row, column];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    X[i, j] = new Random().Next(minn, maxn);
            return X;
        }
        /// <summary>
        /// parametre olarak aldığı matrisi ekrana yazar
        /// </summary>
        /// <param name="X">matris</param>
        public static void MatrisYazdir(int[,] X)
        {
            Console.WriteLine();
            Console.WriteLine("OLUŞTURULAN MATRİS:");
            Console.WriteLine();
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    Console.Write("{0,10}", X[i, j]);
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// tek boyutlu diziyi yazdırır
        /// </summary>
        /// <param name="X">dizi</param>
        public static void MatrisYazdir(int[] X)
        {
            Console.WriteLine();
            for (int i = 0; i < X.Length; i++)
            {
                Console.Write("{0,10}", X[i]);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// sıfır matrisi oluşturur(tüm elemanları sıfırlardan oluşan matris)
        /// </summary>
        /// <param name="satir">satır sayısı</param>
        /// <param name="sutun">sütun sayısı</param>
        /// <returns>sıfır matrisi</returns>
        public static int[,] SifirMatrisiOlustur(int satir, int sutun)
        {
            return MatrisOlustur(satir, sutun, 0, 0);
        }

        /// <summary>
        /// birler matrisi oluşturur(tüm elemanları birlerden oluşan matris)
        /// </summary>
        /// <param name="satir">satır sayısı</param>
        /// <param name="sutun">sütun sayısı</param>
        /// <returns>sıfır matrisi</returns>
        public static int[,] BirlerMatrisiOlustur(int satir, int sutun)
        {
            return MatrisOlustur(satir, sutun, 1, 1);
        }
        /// <summary>
        /// köşegen matris oluşturur
        /// </summary>
        /// <param name="boyut">satır ve sütun sayısı</param>
        /// <param name="min">min değer matris elemanı için</param>
        /// <param name="maks">maks değer matris elemanı için</param>
        /// <returns>köşegen matris döner</returns>
        public static int[,] KosegenMatrisOlustur(int boyut = 3, int min = 1, int maks = 9)
        {
            int[,] X = SifirMatrisiOlustur(boyut, boyut);
            for (int i = 0; i < X.GetLength(1); i++)
            {
                X[i, i] = new Random().Next(min, maks);
            }
            return X;
        }
        /// <summary>
        /// skaler matris oluşturur
        /// </summary>
        /// <param name="boyut">satır/sütun eşit sayıda </param>
        /// <param name="skaler">köşegen üzerindeki matris elemanları aynı olacak</param>
        /// <returns>scaler matris</returns>
        public static int[,] SkalerMatrisOlustur(int boyut = 3, int skaler = 3)
        {
            return KosegenMatrisOlustur(boyut, skaler, skaler);
        }
        /// <summary>
        /// kare matris olup olmadığını denetler
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>kare matris ise doğru değilse yanlış</returns>
        public static bool KareMatrisMi(int[,] X)
        {
            return X.GetLength(0) == X.GetLength(1) ?
                true : false;
        }
        /// <summary>
        /// skaler matris yardımıyla birim matris oluşturur
        /// </summary>
        /// <param name="boyut">matris boyutu</param>
        /// <returns>birim matris</returns>
        public static int[,] BirimMatrisOlustur(int boyut = 3)
        {
            return SkalerMatrisOlustur(boyut, 1);
        }
        /// <summary>
        /// parametre olarak aldığı matrisin birim matris olup olmadığını denetler
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>doğru ya da yanlış</returns>
        public static bool BirimMatrisMi(int[,] X)
        {
            bool s = true;
            for (int i = 0; i < X.GetLength(0) && s == true; i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    //diyagonal elemanlar dılındaki elemanlar 0 mı?
                    if (X[i, j] != 0 && i != j)
                    {
                        s = false;
                        break;
                    }
                    else
                    {
                        // diagonal elemanlar 1 mi?
                        if (X[i, j] != 1 && i == j)
                        {
                            s = false;
                            break;
                        }
                    }
                }
            }
            return s;
        }
        /// <summary>
        /// diyagonal elemanların bir listesini döner
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>diyagonal elemanlar</returns>
        public static int[] DiyagonalElemanlarinListesi(int[,] X)
        {
            if (KareMatrisMi(X))
            {
                int[] D = new int[X.GetLength(0)];
                for (int i = 0; i < X.GetLength(0); i++)
                    D[i] = X[i, i];
                return D;
            }
            else
            {
                Console.WriteLine("Lütfen kare matris giriniz!");
                return new int[1];
            }
        }
        /// <summary>
        /// bir matrisin izini hesaplar (Trace) - Köşegendeki elemanların toplamı
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>köşegen üzerindeki sayılar toplamı</returns>
        public static int Izi(int[,] X)
        {
            int t = 0;
            if (KareMatrisMi(X))
            {
                int[] D = DiyagonalElemanlarinListesi(X);
                for (int i = 0; i < X.GetLength(0); i++)
                    t += X[i, i];
                return t;
            }
            else
                return t;
        }
        /// <summary>
        /// bir matrisin transpozunu alır
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>matrisin transpozu</returns>
        public static int[,] Transpoz(int[,] X)
        {
            int[,] T = new int[X.GetLength(1), X.GetLength(0)];
            for (int i = 0; i < T.GetLength(0); i++)
                for (int j = 0; j < T.GetLength(1); j++)
                    T[i, j] = X[j, i];
            return T;
        }
        /// <summary>
        /// örneğin 3*4 matrisi 4*3, 6*2, 12*1 gibi yeni boyutta yazar
        /// </summary>
        /// <param name="X">matris</param>
        /// <param name="yeniSatir">yeni matrisin satır sayısı</param>
        /// <param name="yeniSutun">yeni matrisin sütun sayısı</param>
        /// <returns></returns>
        public static int[,] YenidenSekillendir(int[,] X,
            int yeniSatir, int yeniSutun)
        {
            if (X.Length == yeniSatir * yeniSutun)
            {
                int[] D = new int[X.Length];
                int sayac = 0;
                int[,] Y = new int[yeniSatir, yeniSutun];
                for (int i = 0; i < X.GetLength(0); i++)
                    for (int j = 0; j < X.GetLength(1); j++)
                    {
                        D[sayac] = X[i, j];
                        sayac++;
                    }
                MatrisYazdir(D);
                sayac = 0;
                for (int i = 0; i < Y.GetLength(0); i++)
                    for (int j = 0; j < yeniSutun; j++)
                    {
                        Y[i, j] = D[sayac];
                        sayac++;
                    }
                return Y;
            }
            else
            {
                Console.WriteLine("Bir Hata Oldu");
                return new int[1, 1];
            }
        }
        /// <summary>
        /// iki matrisin tüm elemanlarının birbirine eşit olup olmadığını kontrol eder
        /// </summary>
        /// <param name="X">ilk matris</param>
        /// <param name="Y">ikinci matris</param>
        /// <returns>matrisler eşit ise doğru, değilse yanlış</returns>
        public static bool EsitMi(int[,] X, int[,] Y)
        {
            bool s = true;

            //boyut kontrolü
            if (X.GetLength(0) == Y.GetLength(0) &&
                X.GetLength(1) == Y.GetLength(1))
            {
                //eleman kontrolü
                for (int i = 0; i < X.GetLength(0); i++)
                    for (int j = 0; j < X.GetLength(1); j++)
                    {
                        if (X[i, j] != Y[i, j])
                        {
                            s = false;
                            break;
                        }
                    }
            }
            else
            {
                s = false;
            }
            return s;
        }
        /// <summary>
        /// 2X2 veya 3X3 boyutlu matrislerde determinant hesaplar1
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>verilen matrisin determinantı</returns>
        public static int Determinant(int[,] X)
        {
            int d = -1;
            if (KareMatrisMi(X))
            {
                if (X.Length == 4)
                    d = X[0, 0] * X[1, 1] - X[0, 1] * X[1, 0];
                else if (X.Length == 9)
                    d = X[0, 0] * (X[1, 1] * X[2, 2] - X[1, 2] * X[2, 1]) -
                        X[0, 1] * (X[1, 0] * X[2, 2] - X[2, 0] * X[1, 2]) +
                        X[0, 2] * (X[1, 0] * X[2, 1] - X[1, 1] * X[2, 0]);
                else
                    Console.WriteLine("Tanımlı bir boyut değil");
                return d;
            }
            else
            {
                YazdirHata("Parametre Kare Matris Olmalı");
                return d;
            }
        }
        /// <summary>
        /// scaler bir değer ile matrisi çarpar
        /// </summary>
        /// <param name="c">scaler değer -  Örneğin; 4 metre, 3 litre, 26 derece gibi örnekler skaler büyüklüklere örnekti</param>
        /// <param name="X">matris</param>
        /// <returns></returns>
        public static int[,] ScalerCarpim(int c, int[,] X)
        {
            for (int i = 0; i < X.GetLength(0); i++)
                for (int j = 0; j < X.GetLength(1); j++)
                    X[i, j] = c * X[i, j];
            return X;
        }
        /// <summary>
        /// bir matrisin elemanlarının toplamı
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>matrisin elemanlarının toplamı</returns>
        public static int ElemanlarinToplami(int[,] X)
        {
            int d = 0;
            for (int i = 0; i < X.GetLength(0); i++)
                for (int j = 0; j < X.GetLength(1); j++)
                    d += X[i, j];
            return d;
        }

        /// <summary>
        /// önce köşegen (köşegen dışındaki elemanları 0 olan matris oluşturur,
        /// köşegen matris köşegeninin altında kalan elemanları rastgele oluşturur
        /// köşegenin üstündeki elemanları da aynı anda kopyalar
        /// </summary>
        /// <param name="boyut">matris boyutu</param>
        /// <param name="min">rastgele elemanlar için min değer</param>
        /// <param name="max">rastgele elemanlar için max değer</param>
        /// <returns></returns>
        public static int[,] SimetrikMatrisOlustur(int boyut = 3, int min = 1, int max = 9)
        {
            int[,] X = KosegenMatrisOlustur(boyut, min, max);
            for (int i = 1; i < X.GetLength(0); i++)
                for (int j = 0; j <= i - 1; j++)
                {
                    X[i, j] = new Random().Next(min, max);
                    X[j, i] = X[i, j];
                }
            return X;
        }
        /// <summary>
        /// matrisin transpozu ile karşılaştırır ve simetrik olup olmadığını denetler
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>simetrik ise doğru,değilse yanlış döner</returns>
        public static bool SimetrikMi(int[,] X)
        {
            int[,] Y = Transpoz(X);
            return EsitMi(X, Y);
        }
        /// <summary>
        /// parametre olarak aldığı matrisin köşegen olup olmadığını denetler
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>doğru ya da yanlış</returns>
        public static bool KosegenMatrisMi(int[,] X)
        {
            bool s = true;
            if (KareMatrisMi(X))
            {
                for (int i = 0; i < X.GetLength(0); i++)
                    for (int j = 0; j < X.GetLength(1); j++)
                        if (!(X[i, j] == 0))
                            if (i != j)
                            {
                                s = false;
                                break;
                            }
            }
            else
            {
                YazdirHata("Kare Matris Değil!");
                s = false;
            }

            int[,] Y = Transpoz(X);
            return s;
        }
        /// <summary>
        /// köşegenin üstündeki değerler farklı, altındakilerin tamamı 0 olan matris oluşturur
        /// </summary>
        /// <param name="boyut">matrisin satır=sütun sayısı</param>
        /// <param name="min">üstteki üçgendeki sayıların minimum değeri</param>
        /// <param name="max">üstteki üçgendeki sayıların maksimum değeri</param>
        /// <returns>üst üçgen matris oluşturur</returns>
        public static int[,] UstUcgenMatrisOlustur(int boyut = 3, int min = 1, int max = 9)
        {
            int[,] X = KosegenMatrisOlustur(boyut, min, max);
            for (int i = 0; i < X.GetLength(0); i++)
                for (int j = i; j < X.GetLength(1); j++)
                    X[i, j] = new Random().Next(min, max);
            return X;
        }
        /// <summary>
        /// köşegenin altındaki değerler farklı, üstündekilerin tamamı 0 olan matris oluşturur
        /// </summary>
        /// <param name="boyut">matrisin satır=sütun sayısı</param>
        /// <param name="min">alttaki üçgendeki sayıların minimum değeri</param>
        /// <param name="max">alttaki üçgendeki sayıların maksimum değeri</param>
        /// <returns></returns>
        public static int[,] AltUcgenMatrisOlustur(int boyut = 3, int min = 1, int max = 9)
        {
            int[,] X = KosegenMatrisOlustur(boyut, min, max);
            for (int i = 0; i < X.GetLength(1); i++)
                for (int j = i; j < X.GetLength(0); j++)
                    X[j, i] = new Random().Next(min, max);
            return X;
        }
        /// <summary>
        /// matrisin üst üçgen matris olup olmadığını denetler
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns> matris üst üçgen matris ise doğru döner</returns>

        public static bool UstUcgenMatrisMi(int[,] X)
        {
            bool s = true;
            for (int i = 0; i < X.GetLength(0); i++)
                for (int j = 0; j < i - 1; j++)
                    if (!(X[i, j] == 0))
                    {
                        s = false;
                        break;
                    }
            return s;
        }
        /// <summary>
        /// matrisin alt üçgen matris olup olmadığını denetler
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns> matris alt üçgen matris ise doğru döner</returns>

        public static bool AltUcgenMatrisMi(int[,] X)
        {
            bool s = true;
            for (int i = 0; i < X.GetLength(0) - 1; i++)
                for (int j = i + 1; j < X.GetLength(1); j++)
                    if (!(X[i, j] == 0))
                    {
                        s = false;
                        break;
                    }
            return s;
        }
    }
}
