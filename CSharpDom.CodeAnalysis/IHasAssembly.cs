﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    public interface IHasAssembly
    {
        AssemblyWithCodeAnalysis Assembly { get; }
    }
}