﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_5
{
    public interface IIterator
    {
        object Current { get; }
        bool Next();
    }
}
