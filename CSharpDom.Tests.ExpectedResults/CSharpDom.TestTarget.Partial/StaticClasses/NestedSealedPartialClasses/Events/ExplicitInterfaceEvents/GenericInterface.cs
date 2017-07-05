namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedSealedPartialClassWithExplicitInterfaceEventWithGenericInterface
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
