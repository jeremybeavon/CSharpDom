﻿namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedAbstractPartialClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
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
