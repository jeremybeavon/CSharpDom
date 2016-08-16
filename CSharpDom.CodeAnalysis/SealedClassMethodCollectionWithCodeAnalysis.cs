using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassMethodCollectionWithCodeAnalysis :
        AbstractSealedClassMethodCollection<
            SealedClassMethodWithCodeAnalysis,
            ExplicitInterfaceMethodWithCodeAnalysis>
    {
        private readonly SealedTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal SealedClassMethodCollectionWithCodeAnalysis(SealedTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }

        public override IReadOnlyCollection<ExplicitInterfaceMethodWithCodeAnalysis> ExplicitInterfaceMethods
        {
            get { return typeWithCodeAnalysis.MethodCollection.Methods.ExplicitInterfaceMethodsWithCodeAnalysis; }
        }

        protected override IReadOnlyCollection<SealedClassMethodWithCodeAnalysis> Methods
        {
            get { return typeWithCodeAnalysis.MethodCollection.Methods.MethodsWithCodeAnalysis; }
        }
    }
}
