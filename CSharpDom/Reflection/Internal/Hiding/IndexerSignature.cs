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
            ParameterSignature,
            AccessorSignature>
    {
        private readonly IReadOnlyList<ParameterSignature> parameters;
        
        public IndexerSignature(PropertyInfo indexer)
        {
            parameters = indexer.GetIndexParameters().ToArray(parameter => new ParameterSignature(parameter));
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
            get { return AccessorSignature.Default; }
        }

        public override ITypeReferenceWithReflection IndexerType
        {
            get { return ReturnTypeSignature.Default; }
        }

        public override IReadOnlyList<ParameterSignature> Parameters
        {
            get { return parameters; }
        }

        public override AccessorSignature SetAccessor
        {
            get { return AccessorSignature.Default; }
        }
    }
}
