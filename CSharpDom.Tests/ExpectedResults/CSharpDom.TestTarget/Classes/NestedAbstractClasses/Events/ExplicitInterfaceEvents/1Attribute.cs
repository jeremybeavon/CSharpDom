namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedAbstractClassWithExplicitInterfaceEventWith1Attribute
    {
        public abstract class Class : IInterfaceWithEvent
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
