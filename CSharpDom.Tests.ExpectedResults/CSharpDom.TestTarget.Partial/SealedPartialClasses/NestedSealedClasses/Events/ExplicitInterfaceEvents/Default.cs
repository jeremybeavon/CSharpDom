namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithExplicitInterfaceEvent
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
