using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractAbstractClassEventCollection<TEvent, TAbstractEvent, TExplicitInterfaceEvent> :
        IAbstractClassEventCollection<TEvent, TAbstractEvent, TExplicitInterfaceEvent>
        where TEvent : IClassEvent
        where TAbstractEvent : IAbstractEvent
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
    {
        public abstract IReadOnlyCollection<TAbstractEvent> AbstractEvents { get; }

        public int Count
        {
            get { return Events.Count + AbstractEvents.Count + ExplicitInterfaceEvents.Count; }
        }

        public abstract IReadOnlyCollection<TExplicitInterfaceEvent> ExplicitInterfaceEvents { get; }

        protected abstract IReadOnlyCollection<TEvent> Events { get; }

        public void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<TEvent> GetEnumerator()
        {
            return Events.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
