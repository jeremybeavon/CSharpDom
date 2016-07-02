namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedAbstractClassWithExplicitInterfaceEvent
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
