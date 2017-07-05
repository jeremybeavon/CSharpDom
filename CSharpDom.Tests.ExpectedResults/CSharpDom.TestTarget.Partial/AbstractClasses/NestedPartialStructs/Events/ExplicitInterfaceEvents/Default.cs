namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedStructWithExplicitInterfaceEvent
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
