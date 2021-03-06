﻿using CSharpDom.CodeGeneration.Tree.Types;
using CSharpDom.Text;
using System;
using System.Linq.Expressions;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class Field
    {
        public Field(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public Expression<Func<object>> InitialValue { get; set; }

        public string RawInitialValue { get; set; }

        public override string ToString()
        {
            return new ReadOnlyField(this).ToSourceCode();
        }
    }
}
