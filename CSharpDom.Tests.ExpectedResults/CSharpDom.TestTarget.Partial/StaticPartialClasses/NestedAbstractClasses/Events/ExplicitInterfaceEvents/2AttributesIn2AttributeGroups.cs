﻿namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
    {
        public abstract class Class : IInterfaceWithEvent
        {
            [Attribute1]
            [Attribute2]
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
