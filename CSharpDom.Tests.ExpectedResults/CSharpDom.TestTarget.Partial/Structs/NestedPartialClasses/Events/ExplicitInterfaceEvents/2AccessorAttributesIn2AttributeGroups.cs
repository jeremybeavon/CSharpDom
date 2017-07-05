﻿namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedPartialClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups
    {
        public class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                [Attribute1]
                [Attribute2]
                add { }
                [Attribute1]
                [Attribute2]
                remove { }
            }
        }
    }
}
