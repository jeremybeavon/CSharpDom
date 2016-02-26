using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class NestedStaticClassMethodCollectionWithReflection :
        AbstractNestedStaticClassMethodCollection<StaticClassMethodWithReflection>
    {
        private readonly StaticTypeWithReflection typeWithReflection;

        internal NestedStaticClassMethodCollectionWithReflection(StaticTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }
        
        protected override IReadOnlyCollection<StaticClassMethodWithReflection> Methods
        {
            get { return typeWithReflection.MethodCollection.Methods.MethodsWithReflection; }
        }
    }
}
