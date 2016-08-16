using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractClassMethodCollectionWithCodeAnalysis :
        AbstractAbstractClassMethodCollection<
            ClassMethodWithCodeAnalysis,
            AbstractMethodWithCodeAnalysis,
            ExplicitInterfaceMethodWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal AbstractClassMethodCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }

        public override IReadOnlyCollection<AbstractMethodWithCodeAnalysis> AbstractMethods
        {
            get { return typeWithCodeAnalysis.MethodCollection.Methods.AbstractMethodsWithCodeAnalysis; }
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
