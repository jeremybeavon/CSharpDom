using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassEventCollectionWithMonoCecil :
        AbstractClassEventCollection<
            ClassEventWithMonoCecil,
            ClassEventPropertyWithMonoCecil,
            ExplicitInterfaceEventWithMonoCecil>
    {
        private readonly ClassTypeWithMonoCecil typeWithMonoCecil;

        internal ClassEventCollectionWithMonoCecil(ClassTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
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
