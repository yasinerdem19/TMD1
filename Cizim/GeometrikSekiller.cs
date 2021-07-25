using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cizim
{
    class Dikdortgen : Sekil
    {
        public Dikdortgen()
        {
            Console.WriteLine("Derived class -> constructor");
        }

        public Dikdortgen(int genislik, int yukseklik, int x, int y) : base(genislik: -5, yukseklik: -5, x:-10, y:-10)
        {
            Console.WriteLine("Derived class -> ctor - 4p");
        }

        public override void Ciz() =>
            Console.Write($"Dikdortgen {Pozisyon}-{Boyut}");
        public override void Tasi(Pozisyon yeniPozisyon)
        {
            Console.WriteLine("");
            Console.Write("Dikdörtgen ");
            base.Tasi(yeniPozisyon);
        }

        public override void YenidenBoyutlandir(int genislik, int yukseklik)
        {
            Boyut.Genislik = genislik;
            Boyut.Yukseklik = yukseklik;
        }
    }
    class Elips : Sekil
    {
        public override void Tasi(Pozisyon yeniPozisyon)
        {
            Console.Write("Elips ");
            base.Tasi(yeniPozisyon);
        }

        public override void YenidenBoyutlandir(int genislik, int yukseklik)
        {
            Boyut.Genislik = genislik;
            Boyut.Yukseklik = yukseklik;
        }
        class Kare : Sekil
        {
            public override void YenidenBoyutlandir(int genislik, int yukseklik)
            {
                throw new NotImplementedException();
            }
        }
    }
}
