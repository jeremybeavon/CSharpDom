namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedClassWithExplicitInterfaceEventWith1Attribute
    {
        public class Class : IInterfaceWithEvent
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
