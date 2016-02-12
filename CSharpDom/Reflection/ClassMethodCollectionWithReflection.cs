using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ClassMethodCollectionWithReflection :
        AbstractClassMethodCollection<ClassMethodWithReflection, ExplicitInterfaceMethodWithReflection>
    {
        private readonly ClassTypeWithReflection typeWithReflection;

        internal ClassMethodCollectionWithReflection(ClassTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<ExplicitInterfaceMethodWithReflection> ExplicitInterfaceMethods
        {
            get { return typeWithReflection.Methods.Methods.ExplicitInterfaceMethodsWithReflection; }
        }

        protected override IReadOnlyCollection<ClassMethodWithReflection> Methods
        {
            get { return typeWithReflection.Methods.Methods.MethodsWithReflection; }
        }
    }
}
