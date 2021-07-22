using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILE
{
    public class Examples
    {
        /// <summary>
        /// exe dosyasının olduğu klasördeki Rakamlar.txt dosyasını ekrana yazar
        /// </summary>
        public static void Okuma()
        {
            try
            {
                //dinamik konum
                string[] yol = Directory.GetCurrentDirectory().Split('\\');
                string dosyaYol = "";
                for (int i = 0; i < yol.Length - 3; i++)//-3 şurdan geliyor: C#'da directory methodunda son 3 satır class ı veriyor, biz exe dosyasının olduğu yerde durduk
                    dosyaYol += yol[i] + '\\';
                dosyaYol += "Rakamlar.txt";
                //dosya okuma yazma
                using (StreamReader sr = new StreamReader(dosyaYol))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// exe dosyasının klasöründe adlar.txt oluşturur ve kod içindeki diziyi yazar. 
        /// dosya yoksa oluşturur varsa değiştirir.
        /// </summary>
        public static void Yazma()
        {
            try
            {
                //dinamik konum
                string[] yol = Directory.GetCurrentDirectory().Split('\\');
                string dosyaYol = "";
                for (int i = 0; i < yol.Length - 3; i++)//-3 şurdan geliyor: C#'da directory methodunda son 3 satır class ı veriyor, biz exe dosyasının olduğu yerde durduk
                    dosyaYol += yol[i] + '\\';
                dosyaYol += "Adlar2.txt";

                string[] adlar = new string[] { "Yasin", "Fatma", "Merve", "Emir", "Akif", "Zeynep", "Asaf" };
                using (StreamWriter sw = new StreamWriter(dosyaYol))
                {
                    foreach (string s in adlar)
                        sw.WriteLine(s);
                    Console.WriteLine("\n Adlar.txt dosyası başarılı şekilde oluşturuldu");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void ExtensionExample()
        {
            string s = "Hello Dear World";
            Console.WriteLine($"{s.KelimeSayisi()}");
        }
    }
}
