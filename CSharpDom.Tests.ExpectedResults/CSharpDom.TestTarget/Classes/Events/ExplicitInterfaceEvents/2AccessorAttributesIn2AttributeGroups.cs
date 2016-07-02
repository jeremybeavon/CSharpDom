namespace CSharpDom.TestTarget.Classes.Events.ExplicitInterfaceEvents
{
    public class ClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups : IInterfaceWithEvent
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
