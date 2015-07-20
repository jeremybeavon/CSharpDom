﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class MethodParameter
    {
        public MethodParameter(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public MethodParameterModifier Modifier { get; set; }

        public TypeReference Type { get; set; }
    }
}
