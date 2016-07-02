namespace CSharpDom.TestTarget.Classes.Events.ExplicitInterfaceEvents
{
    public class ClassWithExplicitInterfaceEvent : IInterfaceWithEvent
    {
        event EventHandler IInterfaceWithEvent.Event
        {
            add { }
            remove { }
        }
    }
}
