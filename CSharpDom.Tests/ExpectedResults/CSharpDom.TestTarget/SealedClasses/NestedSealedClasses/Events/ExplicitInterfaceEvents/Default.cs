namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedSealedClassWithExplicitInterfaceEvent
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
