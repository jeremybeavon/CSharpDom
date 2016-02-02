using CSharpDom.BaseClasses;
using System;
using System.Reflection;
using System.Collections.Generic;
using CSharpDom.Reflection.Internal;
using System.Linq;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class IndexerWithReflection :
        AbstractIndexer<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection,
            ParameterWithReflection,
            AccessorWithReflection>,
        IHasPropertyInfo
    {
        private readonly ITypeWithReflection declaringType;
        private readonly PropertyInfo indexer;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithReflection indexerType;
        private readonly Lazy<Parameters> parameters;
        private readonly AccessorWithReflection getAccessor;
        private readonly AccessorWithReflection setAccessor;

        internal IndexerWithReflection(ITypeWithReflection declaringType, PropertyInfo indexer)
        {
            this.declaringType = declaringType;
            this.indexer = indexer;
            attributes = new Lazy<Attributes>(() => new Attributes(indexer));
            indexerType = TypeReferenceWithReflectionFactory.CreateReference(indexer.PropertyType);
            parameters = new Lazy<Parameters>(() => new Parameters(indexer));
            if (indexer.GetMethod != null)
            {
                getAccessor = new AccessorWithReflection(null, indexer.GetMethod);
            }

            if (indexer.SetMethod != null)
            {
                setAccessor = new AccessorWithReflection(null, indexer.SetMethod);
            }
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public override AccessorWithReflection GetAccessor
        {
            get { return getAccessor; }
        }
        
        public override ITypeReferenceWithReflection IndexerType
        {
            get { return indexerType; }
        }
        
        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get { return parameters.Value.ParametersWithReflection; }
        }

        public PropertyInfo PropertyInfo
        {
            get { return indexer; }
        }

        public override AccessorWithReflection SetAccessor
        {
            get { return setAccessor; }
        }
    }
}
