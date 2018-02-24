using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassEventCollectionWrapper : AbstractWrapper<IClassEventCollection>, IClassEventCollectionWrapper
    {
        public ClassEventCollectionWrapper(IClassEventCollection eventCollection)
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

        public IReadOnlyCollection<IClassEventPropertyWrapper> EventProperties
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

        public IEnumerator<IClassEventWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            IClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
        {
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
