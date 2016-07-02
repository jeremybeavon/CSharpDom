namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedAbstractClassWithExplicitInterfaceEvent
    {
        public abstract class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
