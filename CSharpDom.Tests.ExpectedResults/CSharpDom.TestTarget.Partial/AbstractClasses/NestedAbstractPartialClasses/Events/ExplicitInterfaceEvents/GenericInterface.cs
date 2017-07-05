namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithExplicitInterfaceEventWithGenericInterface
    {
        public abstract class Class : IGenericInterfaceWithEventWithGenericDelegate<EventArgs>
        {
            event EventHandler<EventArgs> IGenericInterfaceWithEventWithGenericDelegate<EventArgs>.Event
            {
                add { }
                remove { }
            }
        }
    }
}
