namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedAbstractPartialClassWithExplicitInterfaceEventWithGenericDelegate
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
