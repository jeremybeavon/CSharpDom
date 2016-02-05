﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Common
{
    public interface IHasExplicitInterface<TInterfaceReference>
    {
        TInterfaceReference ExplicitInterface { get; }
    }
}