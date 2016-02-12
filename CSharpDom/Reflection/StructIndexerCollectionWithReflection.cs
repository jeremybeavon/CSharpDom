using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StructIndexerCollectionWithReflection :
        AbstractStructIndexerCollection<StructIndexerWithReflection, ExplicitInterfaceIndexerWithReflection>
    {
        private readonly StructTypeWithReflection typeWithReflection;

        internal StructIndexerCollectionWithReflection(StructTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<ExplicitInterfaceIndexerWithReflection> ExplicitInterfaceIndexers
        {
            get { return typeWithReflection.Indexers.Indexers.ExplicitInterfaceIndexersWithReflection; }
        }

        protected override IReadOnlyCollection<StructIndexerWithReflection> Indexers
        {
            get { return typeWithReflection.Indexers.Indexers.IndexersWithReflection; }
        }
    }
}
