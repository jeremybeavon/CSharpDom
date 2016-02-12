using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ClassNestedStructCollectionWithReflection :
        AbstractClassNestedStructCollection<ClassNestedStructWithReflection, PartialStructNotSupported>
    {
        private readonly ClassTypeWithReflection typeWithReflection;

        internal ClassNestedStructCollectionWithReflection(ClassTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }
        
        public override IReadOnlyCollection<PartialStructNotSupported> PartialStructs
        {
            get { return new PartialStructNotSupported[0]; }
        }

        protected override IReadOnlyCollection<ClassNestedStructWithReflection> Structs
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedStructs; }
        }
    }
}
