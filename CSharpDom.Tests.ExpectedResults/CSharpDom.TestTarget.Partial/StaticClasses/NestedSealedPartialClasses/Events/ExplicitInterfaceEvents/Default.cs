namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedSealedPartialClassWithExplicitInterfaceEvent
    {
        public sealed class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
