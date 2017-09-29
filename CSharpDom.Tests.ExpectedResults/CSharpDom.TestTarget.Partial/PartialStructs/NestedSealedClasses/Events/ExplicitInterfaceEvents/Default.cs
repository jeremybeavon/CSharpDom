namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public partial struct PartialStructWithNestedSealedClassWithExplicitInterfaceEvent
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
