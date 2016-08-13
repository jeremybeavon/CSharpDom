using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class AbstractIndexerWrapper : AbstractWrapper<IAbstractIndexer>, IAbstractIndexerWrapper
    {
        public AbstractIndexerWrapper(IAbstractIndexer indexer)
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

        public IAbstractTypeWrapper DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IAbstractAccessorWrapper GetAccessor
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

        public IAbstractAccessorWrapper SetAccessor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ClassMemberVisibilityModifier Visibility
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

        public override void VisitAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
     
        }
    }
}
