namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedStructWithExplicitInterfaceEventWith1Attribute
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
