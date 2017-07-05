namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedStructWithExplicitInterfaceEventWith1AccessorAttribute
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
