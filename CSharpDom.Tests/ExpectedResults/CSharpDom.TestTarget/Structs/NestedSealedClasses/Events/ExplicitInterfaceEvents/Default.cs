namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedSealedClassWithExplicitInterfaceEvent
    {
        public sealed class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
