using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassEventCollectionWrapper : AbstractWrapper<IStaticClassEventCollection>, IStaticClassEventCollectionWrapper
    {
        public StaticClassEventCollectionWrapper(IStaticClassEventCollection eventCollection)
            : base(eventCollection)
        {
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IStaticClassEventPropertyWrapper> EventProperties
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

        public IEnumerator<IStaticClassEventWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitStaticClassEventCollection<TEvent, TEventProperty>(
            IStaticClassEventCollection<TEvent, TEventProperty> eventCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
