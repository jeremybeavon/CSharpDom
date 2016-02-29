using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ExplicitInterfaceIndexerWithMonoCecil :
        AbstractExplicitInterfaceIndexer<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            InterfaceReferenceWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            IndexerParameterWithMonoCecil,
            AccessorWithMonoCecil>
    {
        private readonly IndexerWithMonoCecil indexer;
        private readonly InterfaceReferenceWithMonoCecil explicitInterface;

        internal ExplicitInterfaceIndexerWithMonoCecil(ITypeWithMonoCecil declaringType, TypeDefinition interfaceType, PropertyDefinition indexer)
        {
            this.indexer = new IndexerWithMonoCecil(declaringType, indexer);
            explicitInterface = new InterfaceReferenceWithMonoCecil(declaringType.Assembly, interfaceType);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return indexer.Attributes; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return indexer.DeclaringType; }
        }

        public override InterfaceReferenceWithMonoCecil ExplicitInterface
        {
            get { return explicitInterface; }
        }

        public override AccessorWithMonoCecil GetAccessor
        {
            get { return indexer.GetAccessor; }
        }

        public override ITypeReferenceWithMonoCecil IndexerType
        {
            get { return indexer.IndexerType; }
        }

        public override IReadOnlyList<IndexerParameterWithMonoCecil> Parameters
        {
            get { return indexer.Parameters; }
        }

        public override AccessorWithMonoCecil SetAccessor
        {
            get { return indexer.SetAccessor; }
        }
    }
}
