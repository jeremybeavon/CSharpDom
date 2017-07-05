namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedStructWithExplicitInterfaceEventWithGenericDelegate
    {
        public struct Struct : IInterfaceWithEventWithGenericDelegate
        {
            event EventHandler<EventArgs> IInterfaceWithEventWithGenericDelegate.Event
            {
                add { }
                remove { }
            }
        }
    }
}
