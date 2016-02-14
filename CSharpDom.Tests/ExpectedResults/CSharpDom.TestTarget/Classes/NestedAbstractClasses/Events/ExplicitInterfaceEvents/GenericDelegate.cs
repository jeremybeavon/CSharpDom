namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedAbstractClassWithExplicitInterfaceEventWithGenericDelegate
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
