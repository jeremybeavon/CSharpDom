namespace CSharpDom.TestTarget.Partial.PartialClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithExplicitInterfaceEvent : IInterfaceWithEvent
    {
        event EventHandler IInterfaceWithEvent.Event
        {
            add { }
            remove { }
        }
    }
}
