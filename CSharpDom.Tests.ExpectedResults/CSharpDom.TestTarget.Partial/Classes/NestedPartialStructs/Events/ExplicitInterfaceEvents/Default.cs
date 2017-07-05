namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedStructWithExplicitInterfaceEvent
    {
        public struct Struct : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
