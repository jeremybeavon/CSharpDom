using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StructMethodCollectionWithReflection :
        AbstractStructMethodCollection<StructMethodWithReflection, ExplicitInterfaceMethodWithReflection>
    {
        private readonly StructTypeWithReflection typeWithReflection;

        internal StructMethodCollectionWithReflection(StructTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<ExplicitInterfaceMethodWithReflection> ExplicitInterfaceMethods
        {
            get { return typeWithReflection.Methods.Methods.ExplicitInterfaceMethodsWithReflection; }
        }

        protected override IReadOnlyCollection<StructMethodWithReflection> Methods
        {
            get { return typeWithReflection.Methods.Methods.MethodsWithReflection; }
        }
    }
}
