namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public static partial class StaticPartialClassWithNestedClassWithExplicitInterfaceEvent
    {
        public class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
