using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class ClassIndexerCollectionWrapper : AbstractWrapper<IClassIndexerCollection>, IClassIndexerCollectionWrapper
    {
        public ClassIndexerCollectionWrapper(IClassIndexerCollection indexerCollection)
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

        public IEnumerator<IClassIndexerWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            IClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
        {
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
