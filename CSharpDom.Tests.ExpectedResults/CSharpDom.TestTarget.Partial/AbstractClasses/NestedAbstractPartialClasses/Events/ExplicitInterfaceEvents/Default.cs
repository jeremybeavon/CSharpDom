namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithExplicitInterfaceEvent
    {
        public abstract class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
