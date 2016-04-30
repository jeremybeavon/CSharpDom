namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedClassWithExplicitInterfaceEventWithGenericInterface
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
