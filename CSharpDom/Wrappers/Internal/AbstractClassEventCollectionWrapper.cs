using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class AbstractClassEventCollectionWrapper : AbstractWrapper<IAbstractClassEventCollection>,
        IAbstractClassEventCollectionWrapper
    {
        private Func<IReadOnlyCollection<IAbstractEventWrapper>> abstractEvents;
        private Func<int> count;
        private Func<IReadOnlyCollection<IClassEventPropertyWrapper>> eventProperties;
        private Func<IReadOnlyCollection<IExplicitInterfaceEventWrapper>> explicitInterfaceEvents;
        private Func<IEnumerator<IClassEventWrapper>> events;

        public AbstractClassEventCollectionWrapper(IAbstractClassEventCollection eventCollection)
            : base(eventCollection)
        {
        }

        public IReadOnlyCollection<IAbstractEventWrapper> AbstractEvents
        {
            get { return abstractEvents(); }
        }

        public int Count
        {
            get { return count(); }
        }

        public IReadOnlyCollection<IClassEventPropertyWrapper> EventProperties
        {
            get { return eventProperties(); }
        }

        public IReadOnlyCollection<IExplicitInterfaceEventWrapper> ExplicitInterfaceEvents
        {
            get { return explicitInterfaceEvents(); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractClassEventCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAbstractClassEventCollectionChildren(this, visitor);
        }

        public IEnumerator<IClassEventWrapper> GetEnumerator()
        {
            return events();
        }

        public override void VisitAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent>(
            IAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent> eventCollection)
        {
            abstractEvents = () => new ReadOnlyCollectionWrapper<TAbstractEvent, IAbstractEventWrapper>(
                eventCollection.AbstractEvents,
                input => new AbstractEventWrapper(input));
            count = () => eventCollection.Count;
            eventProperties = () => new ReadOnlyCollectionWrapper<TEventProperty, IClassEventPropertyWrapper>(
                eventCollection.EventProperties,
                input => new ClassEventPropertyWrapper(input));
            explicitInterfaceEvents = () => new ReadOnlyCollectionWrapper<TExplicitInterfaceEvent, IExplicitInterfaceEventWrapper>(
                eventCollection.ExplicitInterfaceEvents,
                input => new ExplicitInterfaceEventWrapper(input));
            events = () => eventCollection.Select(@event => new ClassEventWrapper(@event)).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
