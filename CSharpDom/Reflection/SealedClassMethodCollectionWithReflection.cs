using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class SealedClassMethodCollectionWithReflection :
        AbstractSealedClassMethodCollection<
            SealedClassMethodWithReflection,
            ExplicitInterfaceMethodWithReflection>
    {
        private readonly SealedTypeWithReflection typeWithReflection;

        internal SealedClassMethodCollectionWithReflection(SealedTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<ExplicitInterfaceMethodWithReflection> ExplicitInterfaceMethods
        {
            get { return typeWithReflection.MethodCollection.Methods.ExplicitInterfaceMethodsWithReflection; }
        }

        protected override IReadOnlyCollection<SealedClassMethodWithReflection> Methods
        {
            get { return typeWithReflection.MethodCollection.Methods.MethodsWithReflection; }
        }
    }
}
