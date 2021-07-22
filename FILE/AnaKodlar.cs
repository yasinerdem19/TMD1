using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILE
{
    class AnaKodlar
    {
        public static void AnaKod1()
        {
            string dosyaYolu = Dosya.FizikselYol("Adlar.txt");
            var fi = new FileInfo(dosyaYolu);
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.Name);
        }
        public static void AnaKodDosyaKopyalama()
        {
            string kaynak = Dosya.FizikselYol("Adlar.txt");
            string hedef = Dosya.FizikselYol("İsimler.txt");

            Dosya.DosyaKopyalama(kaynak, hedef);
        }
        public static void AnaKodDosyaSilme()
        {
            string kaynak = Dosya.FizikselYol("İsimler.txt");

            Dosya.DosyaSilme(kaynak);
        }
        public static void AnaKodKisi()
        {
            Kisi k = new Kisi();
            Console.WriteLine(k.Adi + " : " + k.Yas);


            Kisi k1 = new Kisi("jhbjh");
            Console.WriteLine(k1.Adi + " : " + k1.Yas);

            Kisi k2 = new Kisi("jhbjh", 566);
            Console.WriteLine(k2.Adi + " : " + k2.Yas);

        }

    }
}
