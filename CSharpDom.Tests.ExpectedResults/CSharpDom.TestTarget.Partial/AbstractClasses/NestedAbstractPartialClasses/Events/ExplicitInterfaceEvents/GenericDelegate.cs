namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithExplicitInterfaceEventWithGenericDelegate
    {
        public abstract class Class : IInterfaceWithEventWithGenericDelegate
        {
            event EventHandler<EventArgs> IInterfaceWithEventWithGenericDelegate.Event
            {
                add { }
                remove { }
            }
        }
    }
}
