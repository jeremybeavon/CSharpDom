using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.Reflection
{
    public sealed class StructCollectionWithReflection :
        AbstractStructCollection<StructWithReflection, PartialStructNotSupported>
    {
        private readonly TypeContainer typeContainer;

        internal StructCollectionWithReflection(TypeContainer typeContainer)
        {
            this.typeContainer = typeContainer;
        }

        public override IReadOnlyCollection<PartialStructNotSupported> PartialStructs
        {
            get { return new PartialStructNotSupported[0]; }
        }

        protected override IReadOnlyCollection<StructWithReflection> Structs
        {
            get { return typeContainer.Structs; }
        }
    }
}
