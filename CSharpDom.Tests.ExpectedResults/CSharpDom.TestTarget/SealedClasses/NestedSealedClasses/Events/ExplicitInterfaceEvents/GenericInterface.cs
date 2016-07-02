namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedSealedClassWithExplicitInterfaceEventWithGenericInterface
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
