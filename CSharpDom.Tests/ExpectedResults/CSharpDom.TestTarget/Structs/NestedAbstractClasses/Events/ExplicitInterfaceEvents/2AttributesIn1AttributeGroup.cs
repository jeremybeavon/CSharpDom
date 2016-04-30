namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup
    {
        public abstract class Class : IInterfaceWithEvent
        {
            [Attribute1, Attribute2]
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
