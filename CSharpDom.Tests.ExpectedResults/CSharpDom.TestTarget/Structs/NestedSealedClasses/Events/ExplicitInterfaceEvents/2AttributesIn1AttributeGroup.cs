﻿namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedSealedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup
    {
        public sealed class Class : IInterfaceWithEvent
        {
            [Attribute1, Attribute2]
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
