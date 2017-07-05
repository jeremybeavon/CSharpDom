namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedPartialClassWithExplicitInterfaceEventWithGenericInterface
    {
        public class Class : IGenericInterfaceWithEventWithGenericDelegate<EventArgs>
        {
            event EventHandler<EventArgs> IGenericInterfaceWithEventWithGenericDelegate<EventArgs>.Event
            {
                add { }
                remove { }
            }
        }
    }
}
