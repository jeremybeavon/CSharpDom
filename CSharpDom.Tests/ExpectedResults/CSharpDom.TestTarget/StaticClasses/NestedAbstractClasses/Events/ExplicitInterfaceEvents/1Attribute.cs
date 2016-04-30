namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedAbstractClassWithExplicitInterfaceEventWith1Attribute
    {
        public abstract class Class : IInterfaceWithEvent
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
