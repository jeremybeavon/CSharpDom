namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedClassWithExplicitInterfaceEventWith1AccessorAttribute
    {
        public class Class : IInterfaceWithEvent
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
