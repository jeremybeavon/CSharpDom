namespace CSharpDom.TestTarget.AbstractClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithExplicitInterfaceEvent : IInterfaceWithEvent
    {
        event EventHandler IInterfaceWithEvent.Event
        {
            add { }
            remove { }
        }
    }
}
