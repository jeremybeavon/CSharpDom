using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class AbstractClassEventCollectionWithReflection :
        AbstractAbstractClassEventCollection<
            ClassEventWithReflection,
            ClassEventPropertyWithReflection,
            AbstractEventWithReflection,
            ExplicitInterfaceEventWithReflection>
    {
        private readonly ClassTypeWithReflection typeWithReflection;

        internal AbstractClassEventCollectionWithReflection(ClassTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<AbstractEventWithReflection> AbstractEvents
        {
            get { return typeWithReflection.EventCollection.Events.AbstractEventsWithReflection; }
        }

        public override IReadOnlyCollection<ClassEventPropertyWithReflection> EventProperties
        {
            get { return typeWithReflection.EventCollection.Events.EventPropertiesWithReflection; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceEventWithReflection> ExplicitInterfaceEvents
        {
            get { return typeWithReflection.EventCollection.Events.ExplictInterfaceEventsWithReflection; }
        }

        protected override IReadOnlyCollection<ClassEventWithReflection> Events
        {
            get { return typeWithReflection.EventCollection.Events.EventsWithReflection; }
        }
    }
}
