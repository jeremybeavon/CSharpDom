using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructCollectionWithMonoCecil :
        AbstractStructCollection<StructWithMonoCecil, PartialStructNotSupported>
    {
        private readonly TypeContainer typeContainer;

        internal StructCollectionWithMonoCecil(TypeContainer typeContainer)
        {
            this.typeContainer = typeContainer;
        }

        public override IReadOnlyCollection<PartialStructNotSupported> PartialStructs
        {
            get { return new PartialStructNotSupported[0]; }
        }

        protected override IReadOnlyCollection<StructWithMonoCecil> Structs
        {
            get { return typeContainer.Structs; }
        }
    }
}
