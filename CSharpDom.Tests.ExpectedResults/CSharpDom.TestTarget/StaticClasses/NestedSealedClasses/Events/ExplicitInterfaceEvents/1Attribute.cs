namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedSealedClassWithExplicitInterfaceEventWith1Attribute
    {
        public sealed class Class : IInterfaceWithEvent
        {
            [Attribute1]
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
