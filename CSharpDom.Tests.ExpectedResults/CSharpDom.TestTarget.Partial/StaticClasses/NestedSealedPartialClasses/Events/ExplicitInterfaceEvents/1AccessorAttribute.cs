﻿namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedSealedPartialClassWithExplicitInterfaceEventWith1AccessorAttribute
    {
        public sealed class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                [Attribute1]
                add { }
                [Attribute1]
                remove { }
            }
        }
    }
}
