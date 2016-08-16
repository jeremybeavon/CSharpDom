using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassMethodCollectionWithCodeAnalysis :
        AbstractClassMethodCollection<ClassMethodWithCodeAnalysis, ExplicitInterfaceMethodWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal ClassMethodCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }

        public override IReadOnlyCollection<ExplicitInterfaceMethodWithCodeAnalysis> ExplicitInterfaceMethods
        {
            get { return typeWithCodeAnalysis.MethodCollection.Methods.ExplicitInterfaceMethodsWithCodeAnalysis; }
        }

        protected override IReadOnlyCollection<ClassMethodWithCodeAnalysis> Methods
        {
            get { return typeWithCodeAnalysis.MethodCollection.Methods.MethodsWithCodeAnalysis; }
        }
    }
}
