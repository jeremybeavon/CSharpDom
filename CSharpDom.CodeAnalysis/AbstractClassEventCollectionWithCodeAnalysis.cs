using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractClassEventCollectionWithCodeAnalysis :
        AbstractAbstractClassEventCollection<
            ClassEventWithCodeAnalysis,
            ClassEventPropertyWithCodeAnalysis,
            AbstractEventWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal AbstractClassEventCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }

        public override IReadOnlyCollection<AbstractEventWithCodeAnalysis> AbstractEvents
        {
            get { return typeWithCodeAnalysis.EventCollection.Events.AbstractEventsWithCodeAnalysis; }
        }

        public override IReadOnlyCollection<ClassEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return typeWithCodeAnalysis.EventCollection.Events.EventPropertiesWithCodeAnalysis; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceEventWithCodeAnalysis> ExplicitInterfaceEvents
        {
            get { return typeWithCodeAnalysis.EventCollection.Events.ExplictInterfaceEventsWithCodeAnalysis; }
        }

        protected override IReadOnlyCollection<ClassEventWithCodeAnalysis> Events
        {
            get { return typeWithCodeAnalysis.EventCollection.Events.EventsWithCodeAnalysis; }
        }
    }
}
