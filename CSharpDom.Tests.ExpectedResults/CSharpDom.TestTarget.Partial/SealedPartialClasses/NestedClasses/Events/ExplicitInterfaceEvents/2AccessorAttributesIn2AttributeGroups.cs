﻿namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups
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
