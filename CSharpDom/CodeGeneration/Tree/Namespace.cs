﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class Namespace : TypeContainer
    {
        public Namespace()
        {
            Namespaces = new Collection<Namespace>();
        }

        public Collection<Namespace> Namespaces { get; set; }
    }
}
