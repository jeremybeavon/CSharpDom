using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructIndexerWrapper : AbstractWrapper<IStructIndexer>, IStructIndexerWrapper
    {
        public StructIndexerWrapper(IStructIndexer indexer)
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

        public IStructTypeWrapper DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStructAccessorWrapper GetAccessor
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

        public IStructAccessorWrapper SetAccessor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public StructMemberVisibilityModifier Visibility
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

        public override void VisitStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
        }
    }
}
