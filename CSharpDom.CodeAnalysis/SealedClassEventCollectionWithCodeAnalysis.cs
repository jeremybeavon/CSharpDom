using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassEventCollectionWithCodeAnalysis :
        AbstractSealedClassEventCollection<
            SealedClassEventWithCodeAnalysis,
            SealedClassEventPropertyWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis>
    {
        private readonly SealedTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal SealedClassEventCollectionWithCodeAnalysis(SealedTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }
        
        public override IReadOnlyCollection<SealedClassEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return typeWithCodeAnalysis.EventCollection.Events.EventPropertiesWithCodeAnalysis; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceEventWithCodeAnalysis> ExplicitInterfaceEvents
        {
            get { return typeWithCodeAnalysis.EventCollection.Events.ExplictInterfaceEventsWithCodeAnalysis; }
        }

        protected override IReadOnlyCollection<SealedClassEventWithCodeAnalysis> Events
        {
            get { return typeWithCodeAnalysis.EventCollection.Events.EventsWithCodeAnalysis; }
        }
    }
}
