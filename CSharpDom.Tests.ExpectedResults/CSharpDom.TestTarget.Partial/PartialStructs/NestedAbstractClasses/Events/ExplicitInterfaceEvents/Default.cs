namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public partial struct PartialStructWithWithNestedAbstractClassWithExplicitInterfaceEvent
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
