namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Events.ExplicitInterfaceEvents
{
    public partial struct PartialStructWithWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup
    {
        public struct Struct : IInterfaceWithEvent
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
