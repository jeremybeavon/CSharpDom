﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public enum MethodParameterModifier
    {
        None,
        This,
        Params,
        Ref,
        Out
    }
}