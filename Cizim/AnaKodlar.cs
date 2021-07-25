using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cizim
{
    class AnaKodlar
    {
        public static void AnaKodlar1()
        {
            var r = new Dikdortgen();//var r = new Sekil();
            r.Pozisyon.X = 23;
            r.Pozisyon.Y = 43;
            r.Boyut.Genislik = 100;
            r.Boyut.Yukseklik = 50;
            r.Ciz();
        }
        public static void AnaKodlar2()
        {
            var r = new Dikdortgen();//var r = new Sekil();
            r.Pozisyon.X = 23;
            r.Pozisyon.Y = 43;
            r.Boyut.Genislik = 100;
            r.Boyut.Yukseklik = 50;
            Program.SekilCiz(r);
            r.Tasi(new Pozisyon { X = 20, Y = 30 });
            Program.SekilCiz(r);
        }
        public static void AnaKodlar3()
        {
            Sekil s1 = new Dikdortgen();
            s1.Pozisyon.X = 50;
            s1.Pozisyon.Y = 60;
            s1.Boyut.Genislik = 10;
            s1.Boyut.Yukseklik = 20;
            Program.SekilCiz(s1);
        }
        public static void AnaKodlar4()
        {
            Sekil s1 = new Dikdortgen();
            s1.Pozisyon.X = 50;
            s1.Pozisyon.Y = 60;
            s1.Boyut.Genislik = 10;
            s1.Boyut.Yukseklik = 20;
        }
        public static void AnaKodlar5()
        {
            Sekil s1 = new Dikdortgen(50,50,100,100);
            Program.SekilCiz(s1);
        }
    }
}
