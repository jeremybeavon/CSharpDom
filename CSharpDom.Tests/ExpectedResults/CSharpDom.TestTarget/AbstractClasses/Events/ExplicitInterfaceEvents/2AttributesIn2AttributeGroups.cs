namespace CSharpDom.TestTarget.AbstractClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups : IInterfaceWithEvent
    {
        [Attribute1]
        [Attribute2]
        event EventHandler IInterfaceWithEvent.Event
        {
            add { }
            remove { }
        }
    }
}
