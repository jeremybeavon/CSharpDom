namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedAbstractPartialClassWithExplicitInterfaceEventWithGenericDelegate
    {
        public abstract class Class : IInterfaceWithEventWithGenericDelegate
        {
            event EventHandler<EventArgs> IInterfaceWithEventWithGenericDelegate.Event
            {
                add { }
                remove { }
            }
        }
    }
}
