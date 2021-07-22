using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELLEME
{
    public class Arac
    {
        #region Fields değişkenleri
        private string marka, model, renk;
        private int yil;
        #endregion

        #region Properties
        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public string Renk { get => renk; set => renk = value; }
        public int Yil { get => yil; set => yil = value; }
        #endregion

        #region Constructors
        public Arac(string marka, string model, 
            string renk, int yil)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            Yil = yil;
        }
        public Arac()
        {

        }
        #endregion

        #region Methods
        public void Calistir() =>
           Console.WriteLine("Araç Çalıştı!");
        public void Durdur() =>
                   Console.WriteLine("Araç Durdu!");

        #endregion

    }
}
