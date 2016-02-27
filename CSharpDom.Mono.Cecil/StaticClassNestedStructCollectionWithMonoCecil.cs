using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticClassNestedStructCollectionWithMonoCecil :
        AbstractStaticClassNestedStructCollection<StaticClassNestedStructWithMonoCecil, PartialStructNotSupported>
    {
        private readonly StaticTypeWithMonoCecil typeWithMonoCecil;

        internal StaticClassNestedStructCollectionWithMonoCecil(StaticTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }
        
        public override IReadOnlyCollection<PartialStructNotSupported> PartialStructs
        {
            get { return new PartialStructNotSupported[0]; }
        }

        protected override IReadOnlyCollection<StaticClassNestedStructWithMonoCecil> Structs
        {
            get { return typeWithMonoCecil.NestedTypeCollection.NestedTypes.NestedStructs; }
        }
    }
}
