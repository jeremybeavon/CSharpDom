namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithNestedStructWithExplicitInterfaceEventWith1AccessorAttribute
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
