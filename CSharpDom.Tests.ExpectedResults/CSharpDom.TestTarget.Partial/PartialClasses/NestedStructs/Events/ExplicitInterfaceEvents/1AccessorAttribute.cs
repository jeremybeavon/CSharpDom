namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithNestedStructWithExplicitInterfaceEventWith1AccessorAttribute
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
