namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithExplicitInterfaceEventWithGenericDelegate
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
