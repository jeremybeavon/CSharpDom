using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StructNestedStructCollectionWithReflection :
        AbstractStructNestedStructCollection<StructNestedStructWithReflection, PartialStructNotSupported>
    {
        private readonly StructTypeWithReflection typeWithReflection;

        internal StructNestedStructCollectionWithReflection(StructTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }
        
        public override IReadOnlyCollection<PartialStructNotSupported> PartialStructs
        {
            get { return new PartialStructNotSupported[0]; }
        }

        protected override IReadOnlyCollection<StructNestedStructWithReflection> Structs
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedStructs; }
        }
    }
}
