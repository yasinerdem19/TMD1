using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILE
{
    class FileStream1
    {
        //FileMode(Create,CreateNew,Append, Open,OpenOrCreate,Truncate)
        //FileAccess(Read,Write,ReadWrite)
        //FileShare(None,Read,Write,ReadWrite)

        //FileStream fs = new FileStream(dosyayol, FileMode.Append, FileAccess.Write, FileShare.None);

        //if (fs.CanRead)......CanSeek,CanTimeout,CanWrite......
        //fs.Close();

        public static void YeniIsimlerEkle()
        {
            string ad = "";
            string dosyaYolu = Dosya.FizikselYol("Adlar.txt");
            //Console.WriteLine("{0}", dosyaAdi);
            //Console.WriteLine(dosyaAdi);

            try
            {
                FileStream fs = new FileStream(dosyaYolu,
                    FileMode.Append,
                    FileAccess.Write,
                    FileShare.None);
                while (ad != "cikis")
                {
                    Console.WriteLine("\n Dosyaya kaydetmek üzere bir isim giriniz");
                    ad = Console.ReadLine();
                    if (ad != "cikis")
                    {
                        if (fs.CanWrite)
                        {
                            byte[] yaz = Encoding.UTF8.GetBytes(ad);
                            fs.Write(yaz, 0, yaz.Length);
                            fs.WriteByte(13);//enter karakteri, alt satıra geçer
                        }
                        else
                        {
                            Console.WriteLine("Yazma Yetkiniz yok");
                        }
                    }
                }
                fs.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
