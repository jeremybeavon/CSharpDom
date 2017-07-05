namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedPartialClassWithExplicitInterfaceEvent
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
