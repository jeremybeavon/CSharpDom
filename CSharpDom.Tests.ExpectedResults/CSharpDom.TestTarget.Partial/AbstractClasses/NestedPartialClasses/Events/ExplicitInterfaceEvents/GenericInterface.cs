namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedPartialClassWithExplicitInterfaceEventWithGenericInterface
    {
        public class Class : IGenericInterfaceWithEventWithGenericDelegate<EventArgs>
        {
            event EventHandler<EventArgs> IGenericInterfaceWithEventWithGenericDelegate<EventArgs>.Event
            {
                add { }
                remove { }
            }
        }
    }
}
