namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedSealedClassWithExplicitInterfaceEventWith1AccessorAttribute
    {
        public sealed class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                [Attribute1]
                add { }
                [Attribute1]
                remove { }
            }
        }
    }
}
