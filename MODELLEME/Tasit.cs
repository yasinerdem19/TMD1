using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELLEME
{
    public class Tasit
    {
        public string Motor { get; set;}
        public double Hacim { get; set; }
        public void Temizle() => Console.WriteLine("Taşıt Temizlendi");
    }
    public enum Motor
    {
        Dizel=55,//indis normalde 0'dan başlar... 
        Benzin,
        LPG,
        Elektrik,
        JetMotor///en sonda nvirgül yok
    }
    public enum Renk
    {
        Beyaz,
        Siyah,
        Gri,
        Kırmızı,
        Yeşil,
        Mavi
    }
}
