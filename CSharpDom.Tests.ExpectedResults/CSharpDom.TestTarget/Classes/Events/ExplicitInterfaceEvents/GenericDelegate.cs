namespace CSharpDom.TestTarget.Classes.Events.ExplicitInterfaceEvents
{
    public class ClassWithExplicitInterfaceEventWithGenericDelegate : IInterfaceWithEventWithGenericDelegate
    {
        event EventHandler<EventArgs> IInterfaceWithEventWithGenericDelegate.Event
        {
            add { }
            remove { }
        }
    }
}
