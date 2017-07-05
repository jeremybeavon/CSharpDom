namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedAbstractPartialClassWithExplicitInterfaceEvent
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
