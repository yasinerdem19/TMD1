using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class Kodlar
    {
        public static void AnaKodlar1()
        {
            IBankaHesap mevduatHesabi = new MevduatHesabi();
            mevduatHesabi.Yatir(100);
            mevduatHesabi.Cek(500);
            mevduatHesabi.Cek(50);
            Console.WriteLine(mevduatHesabi.ToString());
        }
        public static void AnaKodlar2()
        {
            IBankaHesap yatirimHesabi = new YatirimHesabi();
            yatirimHesabi.Yatir(800);
            yatirimHesabi.Cek(950);
            yatirimHesabi.Cek(150);
            Console.WriteLine(yatirimHesabi.ToString());
        }
        public static void AnaKodlar3()
        {
            IBankaHesap mevduatHesabi = new MevduatHesabi();
            ITransfer aktifHesap = new AktifHesap();
            //aktifHesap.Yatir(250);
            mevduatHesabi.Yatir(500);
            aktifHesap.TransferYap(mevduatHesabi, 200);
            Console.WriteLine(aktifHesap.ToString());
            Console.WriteLine(mevduatHesabi.ToString());
        }

        public static void AnaKodlar4()
        {
            IBankaHesap mevduatHesabi = new MevduatHesabi();
            ITransfer aktifHesap = new AktifHesap();
            aktifHesap.Yatir(250);
            mevduatHesabi.Yatir(500);
            aktifHesap.TransferYap(mevduatHesabi, 200);
            Console.WriteLine(aktifHesap.ToString());
            Console.WriteLine(mevduatHesabi.ToString());
        }
        public static void AnaKodlar5()
        {
            IBankaHesap mevduatHesabi = new MevduatHesabi();
            ITransfer aktifHesap = new AktifHesap();
            aktifHesap.Yatir(250);
            mevduatHesabi.Yatir(500);
            aktifHesap.TransferYap(mevduatHesabi, -200);
            Console.WriteLine(aktifHesap.ToString());
            Console.WriteLine(mevduatHesabi.ToString());
        }

    }
}
