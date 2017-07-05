namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithNestedStructWithExplicitInterfaceEventWith1Attribute
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
