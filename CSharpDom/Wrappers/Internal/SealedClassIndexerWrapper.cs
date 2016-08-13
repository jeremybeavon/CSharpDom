using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class SealedClassIndexerWrapper : AbstractWrapper<ISealedClassIndexer>, ISealedClassIndexerWrapper
    {
        public SealedClassIndexerWrapper(ISealedClassIndexer indexer)
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

        public ISealedTypeWrapper DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IClassAccessorWrapper GetAccessor
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

        public SealedClassIndexerInheritanceModifier InheritanceModifier
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

        public IClassAccessorWrapper SetAccessor
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

        public override void VisitSealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            ISealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
        }
    }
}
