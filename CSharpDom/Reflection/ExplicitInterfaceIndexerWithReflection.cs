using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class ExplicitInterfaceIndexerWithReflection :
        AbstractExplicitInterfaceIndexer<
            AttributeWithReflection,
            ITypeWithReflection,
            InterfaceReferenceWithReflection,
            ITypeReferenceWithReflection,
            IndexerParameterWithReflection,
            AccessorWithReflection>
    {
        private readonly IndexerWithReflection indexer;
        private readonly InterfaceReferenceWithReflection explicitInterface;

        internal ExplicitInterfaceIndexerWithReflection(ITypeWithReflection declaringType, Type interfaceType, PropertyInfo indexer)
        {
            this.indexer = new IndexerWithReflection(declaringType, indexer);
            explicitInterface = new InterfaceReferenceWithReflection(interfaceType);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return indexer.Attributes; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return indexer.DeclaringType; }
        }

        public override InterfaceReferenceWithReflection ExplicitInterface
        {
            get { return explicitInterface; }
        }

        public override AccessorWithReflection GetAccessor
        {
            get { return indexer.GetAccessor; }
        }

        public override ITypeReferenceWithReflection IndexerType
        {
            get { return indexer.IndexerType; }
        }

        public override IReadOnlyList<IndexerParameterWithReflection> Parameters
        {
            get { return indexer.Parameters; }
        }

        public override AccessorWithReflection SetAccessor
        {
            get { return indexer.SetAccessor; }
        }
    }
}
