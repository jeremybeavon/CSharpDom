using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class SealedClassEventCollectionWrapper : AbstractWrapper<ISealedClassEventCollection>, ISealedClassEventCollectionWrapper
    {
        public SealedClassEventCollectionWrapper(ISealedClassEventCollection eventCollection)
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

        public IReadOnlyCollection<ISealedClassEventPropertyWrapper> EventProperties
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IExplicitInterfaceEventWrapper> ExplicitInterfaceEvents
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

        public IEnumerator<ISealedClassEventWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitSealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            ISealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
