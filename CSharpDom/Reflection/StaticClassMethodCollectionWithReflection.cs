using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassMethodCollectionWithReflection :
        AbstractStaticClassMethodCollection<
            StaticClassMethodWithReflection,
            ExtensionMethodWithReflection>
    {
        private readonly StaticTypeWithReflection typeWithReflection;

        internal StaticClassMethodCollectionWithReflection(StaticTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<ExtensionMethodWithReflection> ExtensionMethods
        {
            get { return typeWithReflection.MethodCollection.Methods.ExtensionMethodsWithReflection; }
        }

        protected override IReadOnlyCollection<StaticClassMethodWithReflection> Methods
        {
            get { return typeWithReflection.MethodCollection.Methods.MethodsWithReflection; }
        }
    }
}
