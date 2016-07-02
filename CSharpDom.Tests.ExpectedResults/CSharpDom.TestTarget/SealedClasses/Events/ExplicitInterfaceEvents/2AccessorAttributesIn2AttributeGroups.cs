namespace CSharpDom.TestTarget.SealedClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups : IInterfaceWithEvent
    {
        event EventHandler IInterfaceWithEvent.Event
        {
            [Attribute1]
            [Attribute2]
            add { }
            [Attribute1]
            [Attribute2]
            remove { }
        }
    }
}
