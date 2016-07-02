namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedClassWithExplicitInterfaceEvent
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
