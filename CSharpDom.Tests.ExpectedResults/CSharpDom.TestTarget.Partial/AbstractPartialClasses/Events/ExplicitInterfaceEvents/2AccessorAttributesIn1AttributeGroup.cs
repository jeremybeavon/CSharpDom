namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public abstract partial class AbstractPartialClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup : IInterfaceWithEvent
    {
        event EventHandler IInterfaceWithEvent.Event
        {
            [Attribute1, Attribute2]
            add { }
            [Attribute1, Attribute2]
            remove { }
        }
    }
}
