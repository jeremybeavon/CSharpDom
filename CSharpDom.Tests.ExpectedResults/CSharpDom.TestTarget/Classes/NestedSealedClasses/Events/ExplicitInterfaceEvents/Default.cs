namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedSealedClassWithExplicitInterfaceEvent
    {
        public sealed class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
