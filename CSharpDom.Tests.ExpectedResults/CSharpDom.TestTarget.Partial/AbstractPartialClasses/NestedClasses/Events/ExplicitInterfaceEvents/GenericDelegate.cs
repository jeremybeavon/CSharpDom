namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public abstract partial class AbstractPartialClassWithNestedClassWithExplicitInterfaceEventWithGenericDelegate
    {
        public class Class : IInterfaceWithEventWithGenericDelegate
        {
            event EventHandler<EventArgs> IInterfaceWithEventWithGenericDelegate.Event
            {
                add { }
                remove { }
            }
        }
    }
}
