namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedSealedClassWithExplicitInterfaceEventWithGenericInterface
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
