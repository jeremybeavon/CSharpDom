using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class AbstractClassMethodCollectionWithReflection :
        AbstractAbstractClassMethodCollection<
            ClassMethodWithReflection,
            AbstractMethodWithReflection,
            ExplicitInterfaceMethodWithReflection>
    {
        private readonly ClassTypeWithReflection typeWithReflection;

        internal AbstractClassMethodCollectionWithReflection(ClassTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<AbstractMethodWithReflection> AbstractMethods
        {
            get { return typeWithReflection.MethodCollection.Methods.AbstractMethodsWithReflection; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceMethodWithReflection> ExplicitInterfaceMethods
        {
            get { return typeWithReflection.MethodCollection.Methods.ExplicitInterfaceMethodsWithReflection; }
        }

        protected override IReadOnlyCollection<ClassMethodWithReflection> Methods
        {
            get { return typeWithReflection.MethodCollection.Methods.MethodsWithReflection; }
        }
    }
}
