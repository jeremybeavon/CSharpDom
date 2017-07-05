namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedSealedPartialClassWithExplicitInterfaceEventWithGenericDelegate
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
