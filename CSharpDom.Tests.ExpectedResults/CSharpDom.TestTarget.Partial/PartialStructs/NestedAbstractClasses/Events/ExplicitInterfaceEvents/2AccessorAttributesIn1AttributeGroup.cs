namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public partial struct PartialStructWithWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup
    {
        public abstract class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                [Attribute1, Attribute2]
                add { }
                [Attribute1, Attribute2]
                remove { }
            }
        }
    }
}
