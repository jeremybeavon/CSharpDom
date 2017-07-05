namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithExplicitInterfaceEventWithGenericDelegate
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
