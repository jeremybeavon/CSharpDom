namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithExplicitInterfaceEventWithGenericDelegate
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
