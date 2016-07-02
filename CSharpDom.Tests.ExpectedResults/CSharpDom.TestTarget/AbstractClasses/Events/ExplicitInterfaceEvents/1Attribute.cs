namespace CSharpDom.TestTarget.AbstractClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithExplicitInterfaceEventWith1Attribute : IInterfaceWithEvent
    {
        [Attribute1]
        event EventHandler IInterfaceWithEvent.Event
        {
            add { }
            remove { }
        }
    }
}
