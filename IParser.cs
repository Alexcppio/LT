﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_parser
{
    public interface IParser<T> where T : class
    {
        T Parse();
    }
}
