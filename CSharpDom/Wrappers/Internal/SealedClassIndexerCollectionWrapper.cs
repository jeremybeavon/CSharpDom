using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class SealedClassIndexerCollectionWrapper : AbstractWrapper<ISealedClassIndexerCollection>, ISealedClassIndexerCollectionWrapper
    {
        public SealedClassIndexerCollectionWrapper(ISealedClassIndexerCollection indexerCollection)
            : base(indexerCollection)
        {
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IExplicitInterfaceIndexerWrapper> ExplicitInterfaceIndexers
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

        public IEnumerator<ISealedClassIndexerWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitSealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            ISealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
