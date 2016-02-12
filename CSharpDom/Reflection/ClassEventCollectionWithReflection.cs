using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ClassEventCollectionWithReflection :
        AbstractClassEventCollection<
            ClassEventWithReflection,
            ClassEventPropertyWithReflection,
            ExplicitInterfaceEventWithReflection>
    {
        private readonly ClassTypeWithReflection typeWithReflection;

        internal ClassEventCollectionWithReflection(ClassTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<ClassEventPropertyWithReflection> EventProperties
        {
            get { return typeWithReflection.Events.Events.EventPropertiesWithReflection; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceEventWithReflection> ExplicitInterfaceEvents
        {
            get { return typeWithReflection.Events.Events.ExplictInterfaceEventsWithReflection; }
        }

        protected override IReadOnlyCollection<ClassEventWithReflection> Events
        {
            get { return typeWithReflection.Events.Events.EventsWithReflection; }
        }
    }
}
