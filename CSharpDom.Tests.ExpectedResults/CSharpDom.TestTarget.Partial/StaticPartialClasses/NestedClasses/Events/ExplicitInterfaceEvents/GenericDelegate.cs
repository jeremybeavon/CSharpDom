namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public static partial class StaticPartialClassWithNestedClassWithExplicitInterfaceEventWithGenericDelegate
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
