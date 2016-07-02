namespace CSharpDom.TestTarget.Classes.Events.ExplicitInterfaceEvents
{
    public class ClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup : IInterfaceWithEvent
    {
        [Attribute1, Attribute2]
        event EventHandler IInterfaceWithEvent.Event
        {
            add { }
            remove { }
        }
    }
}
