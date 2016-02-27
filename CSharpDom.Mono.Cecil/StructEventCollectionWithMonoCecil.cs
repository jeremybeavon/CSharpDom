using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructEventCollectionWithMonoCecil :
        AbstractStructEventCollection<
            StructEventWithMonoCecil,
            StructEventPropertyWithMonoCecil,
            ExplicitInterfaceEventWithMonoCecil>
    {
        private readonly StructTypeWithMonoCecil typeWithMonoCecil;

        internal StructEventCollectionWithMonoCecil(StructTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }

        public override IReadOnlyCollection<StructEventPropertyWithMonoCecil> EventProperties
        {
            get { return typeWithMonoCecil.EventCollection.Events.EventPropertiesWithMonoCecil; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceEventWithMonoCecil> ExplicitInterfaceEvents
        {
            get { return typeWithMonoCecil.EventCollection.Events.ExplictInterfaceEventsWithMonoCecil; }
        }

        protected override IReadOnlyCollection<StructEventWithMonoCecil> Events
        {
            get { return typeWithMonoCecil.EventCollection.Events.EventsWithMonoCecil; }
        }
    }
}
