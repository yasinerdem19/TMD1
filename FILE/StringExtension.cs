﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILE
{
    public static class StringExtension
    {
        public static int KelimeSayisi(this string s) => s.Split().Length;

    }
}
