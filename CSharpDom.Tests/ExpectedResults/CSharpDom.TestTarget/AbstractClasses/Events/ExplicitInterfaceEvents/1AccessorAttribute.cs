namespace CSharpDom.TestTarget.AbstractClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithExplicitInterfaceEventWith1AccessorAttribute : IInterfaceWithEvent
    {
        event EventHandler IInterfaceWithEvent.Event
        {
            [Attribute1]
            add { }
            [Attribute1]
            remove { }
        }
    }
}
