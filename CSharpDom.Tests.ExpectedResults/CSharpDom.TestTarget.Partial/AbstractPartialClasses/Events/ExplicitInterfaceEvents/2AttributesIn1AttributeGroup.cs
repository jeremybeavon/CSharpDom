namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public abstract partial class AbstractPartialClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup : IInterfaceWithEvent
    {
        [Attribute1, Attribute2]
        event EventHandler IInterfaceWithEvent.Event
        {
            add { }
            remove { }
        }
    }
}
