using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructIndexerCollectionWrapper : AbstractWrapper<IStructIndexerCollection>, IStructIndexerCollectionWrapper
    {
        public StructIndexerCollectionWrapper(IStructIndexerCollection indexerCollection)
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

        public IEnumerator<IStructIndexerWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            IStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
