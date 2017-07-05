namespace CSharpDom.TestTarget.Partial.PartialClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithExplicitInterfaceEventWithGenericDelegate : IInterfaceWithEventWithGenericDelegate
    {
        event EventHandler<EventArgs> IInterfaceWithEventWithGenericDelegate.Event
        {
            add { }
            remove { }
        }
    }
}
