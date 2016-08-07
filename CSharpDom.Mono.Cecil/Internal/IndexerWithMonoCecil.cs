using CSharpDom.BaseClasses;
using System;
using System.Reflection;
using System.Collections.Generic;
using CSharpDom.Mono.Cecil.Internal;
using System.Linq;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class IndexerWithMonoCecil :
        AbstractIndexer<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            IndexerParameterWithMonoCecil,
            AccessorWithMonoCecil>,
        IHasPropertyDefinition
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly PropertyDefinition indexer;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithMonoCecil indexerType;
        private readonly Lazy<Parameters<IndexerParameterWithMonoCecil>> parameters;
        private readonly AccessorWithMonoCecil getAccessor;
        private readonly AccessorWithMonoCecil setAccessor;

        internal IndexerWithMonoCecil(ITypeWithMonoCecil declaringType, PropertyDefinition indexer)
        {
            this.declaringType = declaringType;
            this.indexer = indexer;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, indexer));
            indexerType = TypeReferenceWithMonoCecilFactory.CreateReference(declaringType.Assembly, indexer.PropertyType, indexer);
            parameters = new Lazy<Parameters<IndexerParameterWithMonoCecil>>(
                () => new Parameters<IndexerParameterWithMonoCecil>(declaringType.Assembly, indexer, parameter => new IndexerParameterWithMonoCecil(parameter)));
            if (indexer.GetMethod != null)
            {
                getAccessor = new AccessorWithMonoCecil(declaringType.Assembly, indexer.GetMethod);
            }

            if (indexer.SetMethod != null)
            {
                setAccessor = new AccessorWithMonoCecil(declaringType.Assembly, indexer.SetMethod);
            }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }

        public override AccessorWithMonoCecil GetAccessor
        {
            get { return getAccessor; }
        }
        
        public override ITypeReferenceWithMonoCecil IndexerType
        {
            get { return indexerType; }
        }
        
        public override IReadOnlyList<IndexerParameterWithMonoCecil> Parameters
        {
            get { return parameters.Value.ParametersWithMonoCecil; }
        }

        public PropertyDefinition PropertyDefinition
        {
            get { return indexer; }
        }

        public override AccessorWithMonoCecil SetAccessor
        {
            get { return setAccessor; }
        }
    }
}
