using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class ClassNestedStructCollection : AbstractClassNestedStructCollection
    {
        private readonly ClassTypeWithReflection typeWithReflection;

        internal ClassNestedStructCollection(ClassTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }
        
        protected override IReadOnlyCollection<ClassNestedStructWithReflection> Structs
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedStructs; }
        }
    }
}
