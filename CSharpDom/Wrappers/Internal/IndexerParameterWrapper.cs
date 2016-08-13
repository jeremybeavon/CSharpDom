using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class IndexerParameterWrapper : AbstractWrapper<IParameter>, IIndexerParameterWrapper
    {
        public IndexerParameterWrapper(IParameter parameter)
            : base(parameter)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IndexerParameterModifier Modifier
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ITypeReferenceWrapper ParameterType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public override void VisitIndexerParameter<TAttributeGroup, TTypeReference>(
            IIndexerParameter<TAttributeGroup, TTypeReference> parameter)
        {
        }
    }
}
