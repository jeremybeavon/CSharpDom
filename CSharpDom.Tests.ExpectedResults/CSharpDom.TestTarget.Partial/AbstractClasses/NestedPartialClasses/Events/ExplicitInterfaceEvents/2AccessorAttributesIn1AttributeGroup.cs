﻿namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedPartialClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup
    {
        public class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                [Attribute1, Attribute2]
                add { }
                [Attribute1, Attribute2]
                remove { }
            }
        }
    }
}
