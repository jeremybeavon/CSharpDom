namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedStructWithExplicitInterfaceEventWith1AccessorAttribute
    {
        public struct Struct : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                [Attribute1]
                add { }
                [Attribute1]
                remove { }
            }
        }
    }
}
