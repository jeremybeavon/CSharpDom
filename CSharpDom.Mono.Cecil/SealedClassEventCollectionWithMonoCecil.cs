using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class SealedClassEventCollectionWithMonoCecil :
        AbstractSealedClassEventCollection<
            SealedClassEventWithMonoCecil,
            SealedClassEventPropertyWithMonoCecil,
            ExplicitInterfaceEventWithMonoCecil>
    {
        private readonly SealedTypeWithMonoCecil typeWithMonoCecil;

        internal SealedClassEventCollectionWithMonoCecil(SealedTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }
        
        public override IReadOnlyCollection<SealedClassEventPropertyWithMonoCecil> EventProperties
        {
            get { return typeWithMonoCecil.EventCollection.Events.EventPropertiesWithMonoCecil; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceEventWithMonoCecil> ExplicitInterfaceEvents
        {
            get { return typeWithMonoCecil.EventCollection.Events.ExplictInterfaceEventsWithMonoCecil; }
        }

        protected override IReadOnlyCollection<SealedClassEventWithMonoCecil> Events
        {
            get { return typeWithMonoCecil.EventCollection.Events.EventsWithMonoCecil; }
        }
    }
}
