namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedSealedClassWithExplicitInterfaceEventWithGenericDelegate
    {
        public sealed class Class : IInterfaceWithEventWithGenericDelegate
        {
            event EventHandler<EventArgs> IInterfaceWithEventWithGenericDelegate.Event
            {
                add { }
                remove { }
            }
        }
    }
}
