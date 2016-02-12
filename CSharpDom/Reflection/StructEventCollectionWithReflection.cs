using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StructEventCollectionWithReflection :
        AbstractStructEventCollection<
            StructEventWithReflection,
            StructEventPropertyWithReflection,
            ExplicitInterfaceEventWithReflection>
    {
        private readonly StructTypeWithReflection typeWithReflection;

        internal StructEventCollectionWithReflection(StructTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<StructEventPropertyWithReflection> EventProperties
        {
            get { return typeWithReflection.EventCollection.Events.EventPropertiesWithReflection; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceEventWithReflection> ExplicitInterfaceEvents
        {
            get { return typeWithReflection.EventCollection.Events.ExplictInterfaceEventsWithReflection; }
        }

        protected override IReadOnlyCollection<StructEventWithReflection> Events
        {
            get { return typeWithReflection.EventCollection.Events.EventsWithReflection; }
        }
    }
}
