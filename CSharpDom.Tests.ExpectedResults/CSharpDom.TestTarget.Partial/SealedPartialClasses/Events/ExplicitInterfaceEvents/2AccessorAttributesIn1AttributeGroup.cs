namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup : IInterfaceWithEvent
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
