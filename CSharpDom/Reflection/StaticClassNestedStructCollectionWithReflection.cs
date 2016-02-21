using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassNestedStructCollectionWithReflection :
        AbstractStaticClassNestedStructCollection<StaticClassNestedStructWithReflection, PartialStructNotSupported>
    {
        private readonly StaticTypeWithReflection typeWithReflection;

        internal StaticClassNestedStructCollectionWithReflection(StaticTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }
        
        public override IReadOnlyCollection<PartialStructNotSupported> PartialStructs
        {
            get { return new PartialStructNotSupported[0]; }
        }

        protected override IReadOnlyCollection<StaticClassNestedStructWithReflection> Structs
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedStructs; }
        }
    }
}
