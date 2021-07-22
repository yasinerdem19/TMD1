using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILE
{
    public class Dosya
    {
        public static string FizikselYol(string dosyaAdi)
        {
            string[] yol = Directory.GetCurrentDirectory().Split('\\');
            string dosyaYol = "";
            for (int i = 0; i < yol.Length - 3; i++)//-3 şurdan geliyor: C#'da directory methodunda son 3 satır class ı veriyor, biz exe dosyasının olduğu yerde durduk
                dosyaYol += yol[i] + '\\';
            dosyaYol += dosyaAdi;
            return dosyaYol;
        }
        /// <summary>
        /// dosya kopyalama işlemi gerçekleştirir
        /// </summary>
        /// <param name="kaynak">kaynak dosya yolu</param>
        /// <param name="hedef">hedef dosya yolu</param>
        public static void DosyaKopyalama(string kaynak, string hedef)
        {
            try
            {
                FileInfo fi = new FileInfo(kaynak);
                fi.CopyTo(hedef);
                Console.WriteLine("{0} kaynaklı dosya \n{1} 'e kopyalandı", kaynak, hedef);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }
        /// <summary>
        /// verilen parametre bilgisine bağlı olarak ilgili 
        /// dosyayı kalıcı olarak siler
        /// </summary>
        /// <param name="kaynak">kaynak dosya</param>
        public static void DosyaSilme(string kaynak)
        {
            try
            {
                FileInfo fi = new FileInfo(kaynak);
                fi.Delete();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}"); ;
            }
        }
    }
}
