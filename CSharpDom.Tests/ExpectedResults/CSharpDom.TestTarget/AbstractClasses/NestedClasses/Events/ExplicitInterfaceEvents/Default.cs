namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedClassWithExplicitInterfaceEvent
    {
        public class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
