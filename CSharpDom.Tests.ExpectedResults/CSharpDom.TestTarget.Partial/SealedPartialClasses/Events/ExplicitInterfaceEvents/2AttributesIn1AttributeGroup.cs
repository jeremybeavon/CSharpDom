namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup : IInterfaceWithEvent
    {
        [Attribute1, Attribute2]
        event EventHandler IInterfaceWithEvent.Event
        {
            add { }
            remove { }
        }
    }
}
