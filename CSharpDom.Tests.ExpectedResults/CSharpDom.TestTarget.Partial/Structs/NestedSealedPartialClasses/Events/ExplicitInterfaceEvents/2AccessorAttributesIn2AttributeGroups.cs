﻿namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedSealedPartialClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups
    {
        public sealed class Class : IInterfaceWithEvent
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
