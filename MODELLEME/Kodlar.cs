using System;
using System.Collections.Generic;

namespace MODELLEME
{
    class Kodlar
    {
        public static void Anakod1()
        {
            //Arac benimAracim = new Arac("Skoda","SuperB",
            //    "Gri",2020);
            ////            benimAracim.Motor = "Benzin";


            Arac benimAracim = new Arac();
            benimAracim.Marka = "Skoda";
            benimAracim.Model = "SuperB";
            benimAracim.Renk = Renk.Gri.ToString();
            benimAracim.Yil = 2020;
            benimAracim.Motor = Motor.Dizel.ToString();
            benimAracim.Hacim = 1.6;


            Arac seninAracın = new Arac
            {
                Marka = "Skoda",
                Model = "Octavia",
                Renk = Renk.Beyaz.ToString(),
                Yil = 2019,
                Motor = Motor.Elektrik.ToString(),
                Hacim = 1.5
            };


            benimAracim.ToString();
            seninAracın.ToString();
            benimAracim.Temizle();
        }
        public static void Anakod2()
        {
            List<Arac> filo = new List<Arac>();

            filo.Add(new Arac
            {
                Marka = "Skoda",
                Model = "Octavia",
                Yil=2021,//bilerek farkı yerlere yazdım
                Renk = Renk.Gri.ToString(),
                Motor = Motor.Benzin.ToString(),
                Hacim = 1.6
            });
            filo.Add(new Arac
            {
                Marka = "Opel",
                Model = "Corsa",
                Renk = Renk.Kırmızı.ToString(),
                Motor = Motor.LPG.ToString(),
                Yil = 2019,
                Hacim = 1.8
            });
            filo.Add(new Arac
            {
                Marka = "Renault",
                Model = "Fluence",
                Renk = Renk.Siyah.ToString(),
                Motor = Motor.Dizel.ToString(),
                Yil = 2020,
                Hacim = 1.4
            });


            filo.RemoveAt(0);


            foreach (Arac item in filo)
                item.ToString();
        }
    }
}
