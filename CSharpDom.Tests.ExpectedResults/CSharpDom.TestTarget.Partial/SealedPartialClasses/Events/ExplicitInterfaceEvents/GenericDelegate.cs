namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithExplicitInterfaceEventWithGenericDelegate : IInterfaceWithEventWithGenericDelegate
    {
        event EventHandler<EventArgs> IInterfaceWithEventWithGenericDelegate.Event
        {
            add { }
            remove { }
        }
    }
}
