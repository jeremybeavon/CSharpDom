namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedClassWithExplicitInterfaceEventWith1AccessorAttribute
    {
        public class Class : IInterfaceWithEvent
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
}
