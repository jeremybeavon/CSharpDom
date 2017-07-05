namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Events.ExplicitInterfaceEvents
{
    public partial struct PartialStructWithWithNestedStructWithExplicitInterfaceEventWith1AccessorAttribute
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
