using CSharpDom.BaseClasses;
using System;
using System.Reflection;
using System.Collections.Generic;
using CSharpDom.Mono.Cecil.Internal;
using System.Linq;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class IndexerWithMonoCecil :
        AbstractIndexer<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            IndexerParameterWithMonoCecil,
            AccessorWithMonoCecil>,
        IHasPropertyInfo
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly PropertyInfo indexer;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithMonoCecil indexerType;
        private readonly Lazy<Parameters<IndexerParameterWithMonoCecil>> parameters;
        private readonly AccessorWithMonoCecil getAccessor;
        private readonly AccessorWithMonoCecil setAccessor;

        internal IndexerWithMonoCecil(ITypeWithMonoCecil declaringType, PropertyInfo indexer)
        {
            this.declaringType = declaringType;
            this.indexer = indexer;
            attributes = new Lazy<Attributes>(() => new Attributes(indexer));
            indexerType = TypeReferenceWithMonoCecilFactory.CreateReference(indexer.PropertyType);
            parameters = new Lazy<Parameters<IndexerParameterWithMonoCecil>>(
                () => new Parameters<IndexerParameterWithMonoCecil>(indexer, parameter => new IndexerParameterWithMonoCecil(parameter)));
            if (indexer.GetMethod != null)
            {
                getAccessor = new AccessorWithMonoCecil(indexer.GetMethod);
            }

            if (indexer.SetMethod != null)
            {
                setAccessor = new AccessorWithMonoCecil(indexer.SetMethod);
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

        public PropertyInfo PropertyInfo
        {
            get { return indexer; }
        }

        public override AccessorWithMonoCecil SetAccessor
        {
            get { return setAccessor; }
        }
    }
}
