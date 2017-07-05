namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedStructWithExplicitInterfaceEventWith1Attribute
    {
        public struct Struct : IInterfaceWithEvent
        {
            [Attribute1]
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
