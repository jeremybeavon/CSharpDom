namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Events.ExplicitInterfaceEvents
{
    public partial struct PartialStructWithWithNestedStructWithExplicitInterfaceEvent
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
