namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedPartialClassWithExplicitInterfaceEventWith1Attribute
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
