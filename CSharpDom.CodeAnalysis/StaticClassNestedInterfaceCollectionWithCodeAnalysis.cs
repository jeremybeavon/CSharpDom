using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassNestedInterfaceCollectionWithCodeAnalysis :
        AbstractStaticClassNestedInterfaceCollection<StaticClassNestedInterfaceWithCodeAnalysis, PartialInterfaceNotSupported>
    {
        private readonly StaticTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal StaticClassNestedInterfaceCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }

        public override IReadOnlyCollection<PartialInterfaceNotSupported> PartialInterfaces
        {
            get { return new PartialInterfaceNotSupported[0]; }
        }

        protected override IReadOnlyCollection<StaticClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return typeWithCodeAnalysis.NestedTypeCollection.NestedTypes.NestedInterfaces; }
        }
    }
}
