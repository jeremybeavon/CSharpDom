using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class StructEventCollectionWrapper : AbstractWrapper<IStructEventCollection>, IStructEventCollectionWrapper
    {
        public StructEventCollectionWrapper(IStructEventCollection eventCollection)
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

        public IReadOnlyCollection<IStructEventPropertyWrapper> EventProperties
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

        public IEnumerator<IStructEventWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            IStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
