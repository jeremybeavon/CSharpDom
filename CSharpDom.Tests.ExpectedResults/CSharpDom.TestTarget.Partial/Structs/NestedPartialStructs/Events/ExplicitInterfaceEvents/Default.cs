namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedStructWithExplicitInterfaceEvent
    {
        public struct Struct : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
