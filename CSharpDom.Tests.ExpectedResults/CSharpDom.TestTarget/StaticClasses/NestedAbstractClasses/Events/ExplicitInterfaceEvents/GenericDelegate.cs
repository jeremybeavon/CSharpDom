namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedAbstractClassWithExplicitInterfaceEventWithGenericDelegate
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
