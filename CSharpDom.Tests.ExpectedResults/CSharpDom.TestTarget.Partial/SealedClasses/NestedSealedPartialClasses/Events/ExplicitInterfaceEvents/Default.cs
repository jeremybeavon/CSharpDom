namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedSealedPartialClassWithExplicitInterfaceEvent
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
