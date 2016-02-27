using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class AbstractClassEventCollectionWithMonoCecil :
        AbstractAbstractClassEventCollection<
            ClassEventWithMonoCecil,
            ClassEventPropertyWithMonoCecil,
            AbstractEventWithMonoCecil,
            ExplicitInterfaceEventWithMonoCecil>
    {
        private readonly ClassTypeWithMonoCecil typeWithMonoCecil;

        internal AbstractClassEventCollectionWithMonoCecil(ClassTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }

        public override IReadOnlyCollection<AbstractEventWithMonoCecil> AbstractEvents
        {
            get { return typeWithMonoCecil.EventCollection.Events.AbstractEventsWithMonoCecil; }
        }

        public override IReadOnlyCollection<ClassEventPropertyWithMonoCecil> EventProperties
        {
            get { return typeWithMonoCecil.EventCollection.Events.EventPropertiesWithMonoCecil; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceEventWithMonoCecil> ExplicitInterfaceEvents
        {
            get { return typeWithMonoCecil.EventCollection.Events.ExplictInterfaceEventsWithMonoCecil; }
        }

        protected override IReadOnlyCollection<ClassEventWithMonoCecil> Events
        {
            get { return typeWithMonoCecil.EventCollection.Events.EventsWithMonoCecil; }
        }
    }
}
