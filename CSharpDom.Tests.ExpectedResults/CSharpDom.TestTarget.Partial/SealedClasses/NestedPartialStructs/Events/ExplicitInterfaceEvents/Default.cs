namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedStructWithExplicitInterfaceEvent
    {
        public struct Struct : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
