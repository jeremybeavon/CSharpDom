using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class SealedClassEventCollectionWithReflection :
        AbstractSealedClassEventCollection<
            SealedClassEventWithReflection,
            SealedClassEventPropertyWithReflection,
            ExplicitInterfaceEventWithReflection>
    {
        private readonly SealedTypeWithReflection typeWithReflection;

        internal SealedClassEventCollectionWithReflection(SealedTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }
        
        public override IReadOnlyCollection<SealedClassEventPropertyWithReflection> EventProperties
        {
            get { return typeWithReflection.EventCollection.Events.EventPropertiesWithReflection; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceEventWithReflection> ExplicitInterfaceEvents
        {
            get { return typeWithReflection.EventCollection.Events.ExplictInterfaceEventsWithReflection; }
        }

        protected override IReadOnlyCollection<SealedClassEventWithReflection> Events
        {
            get { return typeWithReflection.EventCollection.Events.EventsWithReflection; }
        }
    }
}
