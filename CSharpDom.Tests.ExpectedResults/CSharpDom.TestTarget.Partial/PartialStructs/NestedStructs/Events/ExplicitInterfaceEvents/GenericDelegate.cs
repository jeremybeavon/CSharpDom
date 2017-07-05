namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Events.ExplicitInterfaceEvents
{
    public partial struct PartialStructWithWithNestedStructWithExplicitInterfaceEventWithGenericDelegate
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
