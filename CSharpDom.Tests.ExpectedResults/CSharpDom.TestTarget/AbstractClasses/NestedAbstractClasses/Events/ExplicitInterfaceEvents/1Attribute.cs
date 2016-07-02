namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedAbstractClassWithExplicitInterfaceEventWith1Attribute
    {
        public abstract class Class : IInterfaceWithEvent
        {
            [Attribute1]
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
