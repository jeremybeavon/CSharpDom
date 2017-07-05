namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public partial struct PartialStructWithWithNestedAbstractClassWithExplicitInterfaceEventWith1AccessorAttribute
    {
        public abstract class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                [Attribute1]
                add { }
                [Attribute1]
                remove { }
            }
        }
    }
}
