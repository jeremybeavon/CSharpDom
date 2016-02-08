using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection.Internal.Hiding
{
    internal sealed class IndexerSignature :
        AbstractIndexer<
            AttributeGroupNotSupported,
            IBasicType,
            ITypeReferenceWithReflection,
            ParameterWithReflection,
            AccessorSignature>
    {
        private readonly ITypeReferenceWithReflection indexerType;
        private readonly IReadOnlyList<ParameterWithReflection> parameters;
        private readonly AccessorSignature getAccessor;
        private readonly AccessorSignature setAccessor;

        public IndexerSignature(PropertyInfo indexer)
        {
            indexerType = TypeReferenceWithReflectionFactory.CreateReference(indexer.PropertyType);
            parameters = new Parameters(indexer).ParametersWithReflection;
            if (indexer.GetMethod != null)
            {
                getAccessor = AccessorSignature.Default;
            }

            if (indexer.SetMethod != null)
            {
                setAccessor = AccessorSignature.Default;
            }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IBasicType DeclaringType
        {
            get { return null; }
        }

        public override AccessorSignature GetAccessor
        {
            get { return getAccessor; }
        }

        public override ITypeReferenceWithReflection IndexerType
        {
            get { return indexerType; }
        }

        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get { return parameters; }
        }

        public override AccessorSignature SetAccessor
        {
            get { return setAccessor; }
        }
    }
}
