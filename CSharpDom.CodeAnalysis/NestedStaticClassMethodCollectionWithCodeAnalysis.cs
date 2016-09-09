using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NestedStaticClassMethodCollectionWithCodeAnalysis :
        EditableNestedStaticClassMethodCollection<StaticClassMethodWithCodeAnalysis>
    {
        private readonly StaticClassMethodCollectionWithCodeAnalysis methods;

        internal NestedStaticClassMethodCollectionWithCodeAnalysis(StaticClassMethodCollectionWithCodeAnalysis methods)
        {
            this.methods = methods;
        }
        
        public override ICollection<StaticClassMethodWithCodeAnalysis> Methods
        {
            get { return methods.Methods; }
            set { methods.Methods = value; }
        }
    }
}
