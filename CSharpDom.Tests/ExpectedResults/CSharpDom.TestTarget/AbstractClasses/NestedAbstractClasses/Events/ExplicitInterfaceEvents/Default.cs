namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedAbstractClassWithExplicitInterfaceEvent
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
