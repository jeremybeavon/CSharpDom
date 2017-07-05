namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Events.ExplicitInterfaceEvents
{
    public partial struct PartialStructWithWithNestedStructWithExplicitInterfaceEventWith1Attribute
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
