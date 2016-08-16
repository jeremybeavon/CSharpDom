using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructEventCollectionWithCodeAnalysis :
        AbstractStructEventCollection<
            StructEventWithCodeAnalysis,
            StructEventPropertyWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis>
    {
        private readonly StructTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal StructEventCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }

        public override IReadOnlyCollection<StructEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return typeWithCodeAnalysis.EventCollection.Events.EventPropertiesWithCodeAnalysis; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceEventWithCodeAnalysis> ExplicitInterfaceEvents
        {
            get { return typeWithCodeAnalysis.EventCollection.Events.ExplictInterfaceEventsWithCodeAnalysis; }
        }

        protected override IReadOnlyCollection<StructEventWithCodeAnalysis> Events
        {
            get { return typeWithCodeAnalysis.EventCollection.Events.EventsWithCodeAnalysis; }
        }
    }
}
