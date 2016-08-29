using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassEventCollectionWithCodeAnalysis :
        EditableClassEventCollection<
            ClassEventWithCodeAnalysis,
            ClassEventPropertyWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis>,

    {
        private readonly 

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
