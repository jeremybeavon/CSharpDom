using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticClassEventCollectionWithMonoCecil :
        AbstractStaticClassEventCollection<
            StaticClassEventWithMonoCecil,
            StaticClassEventPropertyWithMonoCecil>
    {
        private readonly StaticTypeWithMonoCecil typeWithMonoCecil;

        internal StaticClassEventCollectionWithMonoCecil(StaticTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }
        
        public override IReadOnlyCollection<StaticClassEventPropertyWithMonoCecil> EventProperties
        {
            get { return typeWithMonoCecil.EventCollection.Events.EventPropertiesWithMonoCecil; }
        }
        
        protected override IReadOnlyCollection<StaticClassEventWithMonoCecil> Events
        {
            get { return typeWithMonoCecil.EventCollection.Events.EventsWithMonoCecil; }
        }
    }
}
