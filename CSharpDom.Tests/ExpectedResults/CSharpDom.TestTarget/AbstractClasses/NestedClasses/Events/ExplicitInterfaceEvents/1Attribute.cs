namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedClassWithExplicitInterfaceEventWith1Attribute
    {
        public class Class : IInterfaceWithEvent
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
