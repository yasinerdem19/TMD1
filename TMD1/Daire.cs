using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMD1
{
    public class Daire
    {
        public const double pi= 3.14;
        /// <summary>
        /// Dairenin alanını hesaplar
        /// </summary>
        /// <param name="r">Yarıçap</param>
        /// <returns>Dairenin alanı</returns>
        public static double Alani(double r)
        {
            return pi * r * r;
        }
        public static double AlaniHesapla(double r)
        {
            return pi * r * r;
        }
        /// <summary>
        /// dairenin alanını hesaplar
        /// </summary>
        /// <param name="r">yarıçap</param>
        /// <param name="aci">gördüğü alan</param>
        /// <returns>açının gördüğü alan</returns>

        public static double AlaniHesapla(double r, double aci)
        {
            return pi * r * r * aci / 360;
        }
        public static double AlaniHesaplaFormul(double r)
        {
            return pi* (double)Math.Pow(r,2);
        }
        
    }
}
