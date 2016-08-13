using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ExplicitInterfaceIndexerWrapper : AbstractWrapper<IExplicitInterfaceIndexer>, IExplicitInterfaceIndexerWrapper
    {
        public ExplicitInterfaceIndexerWrapper(IExplicitInterfaceIndexer indexer)
            : base(indexer)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ITypeWrapper DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IInterfaceReferenceWrapper ExplicitInterface
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IAccessorWrapper GetAccessor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ITypeReferenceWrapper IndexerType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyList<IIndexerParameterWrapper> Parameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IAccessorWrapper SetAccessor
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

        public override void VisitExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor>(
            IExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor> indexer)
        {
        }
    }
}
