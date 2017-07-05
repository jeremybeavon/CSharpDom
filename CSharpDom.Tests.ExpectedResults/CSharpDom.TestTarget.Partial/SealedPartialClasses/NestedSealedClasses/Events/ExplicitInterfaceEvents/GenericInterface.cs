namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithExplicitInterfaceEventWithGenericInterface
    {
        public sealed class Class : IGenericInterfaceWithEventWithGenericDelegate<EventArgs>
        {
            event EventHandler<EventArgs> IGenericInterfaceWithEventWithGenericDelegate<EventArgs>.Event
            {
                add { }
                remove { }
            }
        }
    }
}
