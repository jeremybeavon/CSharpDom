namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithExplicitInterfaceEventWithGenericDelegate
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
