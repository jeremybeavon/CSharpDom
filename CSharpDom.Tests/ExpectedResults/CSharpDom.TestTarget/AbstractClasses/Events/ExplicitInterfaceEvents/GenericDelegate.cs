namespace CSharpDom.TestTarget.AbstractClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithExplicitInterfaceEventWithGenericDelegate : IInterfaceWithEventWithGenericDelegate
    {
        event EventHandler<EventArgs> IInterfaceWithEventWithGenericDelegate.Event
        {
            add { }
            remove { }
        }
    }
}
