using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructNestedInterfaceCollectionWithCodeAnalysis :
        AbstractStructNestedInterfaceCollection<StructNestedInterfaceWithCodeAnalysis, PartialInterfaceNotSupported>
    {
        private readonly StructTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal StructNestedInterfaceCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }

        public override IReadOnlyCollection<PartialInterfaceNotSupported> PartialInterfaces
        {
            get { return new PartialInterfaceNotSupported[0]; }
        }

        protected override IReadOnlyCollection<StructNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return typeWithCodeAnalysis.NestedTypeCollection.NestedTypes.NestedInterfaces; }
        }
    }
}
