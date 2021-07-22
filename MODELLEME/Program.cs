using System;

namespace MODELLEME
{
    class Program
    {
        static void Main(string[] args)
        {
            Arac benimAracim = new Arac("Skoda","SuperB",
                "Gri",2020);
            Console.WriteLine($"{benimAracim.Marka}");
            Console.WriteLine($"{benimAracim.Model}");
            Console.WriteLine($"{benimAracim.Renk}");
            Console.WriteLine($"{benimAracim.Yil}");
        }
    }
}
