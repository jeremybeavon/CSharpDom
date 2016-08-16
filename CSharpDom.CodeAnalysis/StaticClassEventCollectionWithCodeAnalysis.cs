using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassEventCollectionWithCodeAnalysis :
        AbstractStaticClassEventCollection<
            StaticClassEventWithCodeAnalysis,
            StaticClassEventPropertyWithCodeAnalysis>
    {
        private readonly StaticTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal StaticClassEventCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }
        
        public override IReadOnlyCollection<StaticClassEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return typeWithCodeAnalysis.EventCollection.Events.EventPropertiesWithCodeAnalysis; }
        }
        
        protected override IReadOnlyCollection<StaticClassEventWithCodeAnalysis> Events
        {
            get { return typeWithCodeAnalysis.EventCollection.Events.EventsWithCodeAnalysis; }
        }
    }
}
