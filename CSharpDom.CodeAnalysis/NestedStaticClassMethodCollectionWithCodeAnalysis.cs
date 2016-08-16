using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NestedStaticClassMethodCollectionWithCodeAnalysis :
        AbstractNestedStaticClassMethodCollection<StaticClassMethodWithCodeAnalysis>
    {
        private readonly StaticTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal NestedStaticClassMethodCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }
        
        protected override IReadOnlyCollection<StaticClassMethodWithCodeAnalysis> Methods
        {
            get { return typeWithCodeAnalysis.MethodCollection.Methods.MethodsWithCodeAnalysis; }
        }
    }
}
