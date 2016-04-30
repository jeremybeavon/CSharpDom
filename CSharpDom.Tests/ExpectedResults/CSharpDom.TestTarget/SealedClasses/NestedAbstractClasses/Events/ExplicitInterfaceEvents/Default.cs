namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedAbstractClassWithExplicitInterfaceEvent
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
