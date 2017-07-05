namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
    {
        public struct Struct : IInterfaceWithEvent
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
