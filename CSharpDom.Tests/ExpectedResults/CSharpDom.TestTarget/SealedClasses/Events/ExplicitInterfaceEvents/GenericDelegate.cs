namespace CSharpDom.TestTarget.SealedClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithExplicitInterfaceEventWithGenericDelegate : IInterfaceWithEventWithGenericDelegate
    {
        event EventHandler<EventArgs> IInterfaceWithEventWithGenericDelegate.Event
        {
            add { }
            remove { }
        }
    }
}
