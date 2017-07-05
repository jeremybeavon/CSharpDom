namespace CSharpDom.TestTarget.Partial.PartialClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup : IInterfaceWithEvent
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
