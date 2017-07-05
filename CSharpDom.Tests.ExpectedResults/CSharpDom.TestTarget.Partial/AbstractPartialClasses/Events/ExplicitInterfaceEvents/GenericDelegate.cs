namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public abstract partial class AbstractPartialClassWithExplicitInterfaceEventWithGenericDelegate : IInterfaceWithEventWithGenericDelegate
    {
        event EventHandler<EventArgs> IInterfaceWithEventWithGenericDelegate.Event
        {
            add { }
            remove { }
        }
    }
}
