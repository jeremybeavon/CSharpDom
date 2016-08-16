using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructMethodCollectionWithCodeAnalysis :
        AbstractStructMethodCollection<StructMethodWithCodeAnalysis, ExplicitInterfaceMethodWithCodeAnalysis>
    {
        private readonly StructTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal StructMethodCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }

        public override IReadOnlyCollection<ExplicitInterfaceMethodWithCodeAnalysis> ExplicitInterfaceMethods
        {
            get { return typeWithCodeAnalysis.MethodCollection.Methods.ExplicitInterfaceMethodsWithCodeAnalysis; }
        }

        protected override IReadOnlyCollection<StructMethodWithCodeAnalysis> Methods
        {
            get { return typeWithCodeAnalysis.MethodCollection.Methods.MethodsWithCodeAnalysis; }
        }
    }
}
