namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithExplicitInterfaceEvent
    {
        public abstract class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
