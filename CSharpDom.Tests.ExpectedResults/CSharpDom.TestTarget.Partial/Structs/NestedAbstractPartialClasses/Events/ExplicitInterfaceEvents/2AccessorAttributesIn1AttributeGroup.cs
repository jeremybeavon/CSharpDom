namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedAbstractPartialClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup
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
