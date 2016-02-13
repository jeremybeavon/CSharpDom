namespace CSharpDom.TestTarget.Classes.Events
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
