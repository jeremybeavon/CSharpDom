using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class SealedClassNestedStructCollection : AbstractClassNestedStructCollection
    {
        private readonly SealedTypeWithReflection typeWithReflection;

        internal SealedClassNestedStructCollection(SealedTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }
        
        protected override IReadOnlyCollection<ClassNestedStructWithReflection> Structs
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedStructs; }
        }
    }
}
