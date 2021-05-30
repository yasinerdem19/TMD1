using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMD1
{
    class UnNumeric
    {
        public static void CharVeRakam()
        {
            for (int i = 1; i <= 300; i++)
            {
                Console.Write("{0,5}", (char)i);
                if (i % 15 == 0) Console.WriteLine("");
            }
        }
        public static void Tests()
        {
            Console.WriteLine(new string('-', 55));
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0}", new string('&', 10));
            }
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0,10}", new string('&', i));
            }
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0}", new string('&', i));
            }
        }
        /// <summary>
        /// desen oluşturucu
        /// </summary>
        /// <param name="c">karakter tanımı</param>
        /// <param name="n">tekrar sayısı</param>
        public static void Desen1(char c='*', int n = 15)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("{0,20}", new string(c, i));
            }
        }
        public static void Tests2()
        {
            UnNumeric.Desen1('>', 15);
        }
        public static void Tests3()
        {
            UnNumeric.Desen1();
            UnNumeric.Desen1('!');
            UnNumeric.Desen1('?', 3);
        }
        public static void Desen2(char c = '-', int n = 4)
        {
            for (int i = n; i >= 0; i--)
                Console.WriteLine("{0,15}", new string(c, i));
        }
        public static void Tests4()
        {
            UnNumeric.Desen2();
            UnNumeric.Desen2('!');
            UnNumeric.Desen2('?', 13);
        }
        public static void Desen3(int baslangicIndisi = 65, int bitisIndisi = 90, int satirKarakterSaysisi = 5)
        {
            for (int i = baslangicIndisi; i <= bitisIndisi; i++)
            { 
                Console.Write("{0,5}",(char)i);
            if (i % satirKarakterSaysisi==0)
                Console.WriteLine();
            }
        }
        public static void Tests5()
        {
            UnNumeric.Desen3();
            Console.WriteLine("------------------------------------");
            UnNumeric.Desen3(128, 255);
            Console.WriteLine("------------------------------------");
            UnNumeric.Desen3(128, 255, 10);
        }
        public static void Tests6()
        {
            string ifade = " Afacan ";
            Console.WriteLine(ifade);
            Console.WriteLine(ifade.Length);
            Console.WriteLine(ifade.Trim());
            Console.WriteLine(ifade.TrimStart());
            Console.WriteLine(ifade.TrimEnd());
            Console.WriteLine(ifade.ToLower());
            Console.WriteLine(ifade.ToUpper());
            Console.WriteLine(ifade.Replace('a','w'));
        }
    }
}
