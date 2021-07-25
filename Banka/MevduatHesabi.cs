using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class MevduatHesabi : IBankaHesap
    {
        private decimal _bakiye;
        public decimal Bakiye => _bakiye;

        public bool Cek(decimal miktar)
        {
            if (_bakiye>=miktar)
            {
                _bakiye -= miktar;
                return  true;
            }
            Console.WriteLine("Yeterli Bakiye Yok");
            return false;
        }

        public void Yatir(decimal miktar) => _bakiye += miktar;

        public override string ToString() => $"Mevduat Hesabı Bakiyesi: {_bakiye,6:C}";
    }
}
