namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedSealedPartialClassWithExplicitInterfaceEvent
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
