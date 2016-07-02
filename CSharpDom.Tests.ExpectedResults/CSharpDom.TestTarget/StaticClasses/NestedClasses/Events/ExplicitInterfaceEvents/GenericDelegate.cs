namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedClassWithExplicitInterfaceEventWithGenericDelegate
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
