namespace CSharpDom.TestTarget.Structs.NestedClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedClassWithExplicitInterfaceEvent
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
