using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassEventCollectionWithReflection :
        AbstractStaticClassEventCollection<
            StaticClassEventWithReflection,
            StaticClassEventPropertyWithReflection>
    {
        private readonly StaticTypeWithReflection typeWithReflection;

        internal StaticClassEventCollectionWithReflection(StaticTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }
        
        public override IReadOnlyCollection<StaticClassEventPropertyWithReflection> EventProperties
        {
            get { return typeWithReflection.EventCollection.Events.EventPropertiesWithReflection; }
        }
        
        protected override IReadOnlyCollection<StaticClassEventWithReflection> Events
        {
            get { return typeWithReflection.EventCollection.Events.EventsWithReflection; }
        }
    }
}
