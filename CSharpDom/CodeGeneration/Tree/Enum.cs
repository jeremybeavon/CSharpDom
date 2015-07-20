﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class Enum
    {
        public Enum(string name)
        {
            Name = name;
            Fields = new Collection<EnumField>();
        }

        public string Name { get; set; }

        public EnumBaseType BaseType { get; set; }

        public Collection<EnumField> Fields { get; set; }
    }
}
