namespace CSharpDom.TestTarget.Classes.Events.ExplicitInterfaceEvents
{
    public class ClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups : IInterfaceWithEvent
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
