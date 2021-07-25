﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public interface IBankaHesap
    {
        void Yatir(decimal miktar);
        bool Cek(decimal miktar);
        decimal Bakiye { get; }
    }
}
