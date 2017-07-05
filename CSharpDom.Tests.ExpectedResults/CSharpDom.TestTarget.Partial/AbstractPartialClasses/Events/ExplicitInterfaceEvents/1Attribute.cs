namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public abstract partial class AbstractPartialClassWithExplicitInterfaceEventWith1Attribute : IInterfaceWithEvent
    {
        [Attribute1]
        event EventHandler IInterfaceWithEvent.Event
        {
            add { }
            remove { }
        }
    }
}
