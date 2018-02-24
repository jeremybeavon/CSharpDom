using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class AbstractClassIndexerCollectionWrapper : AbstractWrapper<IAbstractClassIndexerCollection>,
        IAbstractClassIndexerCollectionWrapper
    {
        public AbstractClassIndexerCollectionWrapper(IAbstractClassIndexerCollection indexerCollection)
            : base(indexerCollection)
        {
        }

        public IReadOnlyCollection<IAbstractIndexerWrapper> AbstractIndexers
        {
            get
            {
                throw new NotImplementedException();
            }
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

        public IEnumerator<IClassIndexerWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer>(
            IAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer> indexerCollection)
        {
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
