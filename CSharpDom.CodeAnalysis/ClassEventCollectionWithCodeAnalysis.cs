using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassEventCollectionWithCodeAnalysis :
        AbstractClassEventCollection<
            ClassEventWithCodeAnalysis,
            ClassEventPropertyWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal ClassEventCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
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
