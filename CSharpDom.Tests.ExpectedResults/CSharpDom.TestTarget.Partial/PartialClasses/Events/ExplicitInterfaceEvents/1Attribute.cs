namespace CSharpDom.TestTarget.Partial.PartialClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithExplicitInterfaceEventWith1Attribute : IInterfaceWithEvent
    {
        [Attribute1]
        event EventHandler IInterfaceWithEvent.Event
        {
            add { }
            remove { }
        }
    }
}
