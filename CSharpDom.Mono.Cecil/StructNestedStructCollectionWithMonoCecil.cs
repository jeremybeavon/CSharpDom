using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructNestedStructCollectionWithMonoCecil :
        AbstractStructNestedStructCollection<StructNestedStructWithMonoCecil, PartialStructNotSupported>
    {
        private readonly StructTypeWithMonoCecil typeWithMonoCecil;

        internal StructNestedStructCollectionWithMonoCecil(StructTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }
        
        public override IReadOnlyCollection<PartialStructNotSupported> PartialStructs
        {
            get { return new PartialStructNotSupported[0]; }
        }

        protected override IReadOnlyCollection<StructNestedStructWithMonoCecil> Structs
        {
            get { return typeWithMonoCecil.NestedTypeCollection.NestedTypes.NestedStructs; }
        }
    }
}
