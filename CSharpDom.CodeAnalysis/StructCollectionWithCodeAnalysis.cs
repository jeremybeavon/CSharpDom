using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructCollectionWithCodeAnalysis :
        AbstractStructCollection<StructWithCodeAnalysis, PartialStructNotSupported>
    {
        private readonly TypeContainer typeContainer;

        internal StructCollectionWithCodeAnalysis(TypeContainer typeContainer)
        {
            this.typeContainer = typeContainer;
        }

        public override IReadOnlyCollection<PartialStructNotSupported> PartialStructs
        {
            get { return new PartialStructNotSupported[0]; }
        }

        protected override IReadOnlyCollection<StructWithCodeAnalysis> Structs
        {
            get { return typeContainer.Structs; }
        }
    }
}
