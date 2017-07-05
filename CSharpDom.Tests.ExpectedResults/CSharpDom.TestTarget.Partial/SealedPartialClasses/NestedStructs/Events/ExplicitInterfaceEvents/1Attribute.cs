namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithNestedStructWithExplicitInterfaceEventWith1Attribute
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
