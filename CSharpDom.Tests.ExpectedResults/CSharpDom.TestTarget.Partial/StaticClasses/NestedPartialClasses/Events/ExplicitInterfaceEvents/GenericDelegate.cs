namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedPartialClassWithExplicitInterfaceEventWithGenericDelegate
    {
        public class Class : IInterfaceWithEventWithGenericDelegate
        {
            event EventHandler<EventArgs> IInterfaceWithEventWithGenericDelegate.Event
            {
                add { }
                remove { }
            }
        }
    }
}
