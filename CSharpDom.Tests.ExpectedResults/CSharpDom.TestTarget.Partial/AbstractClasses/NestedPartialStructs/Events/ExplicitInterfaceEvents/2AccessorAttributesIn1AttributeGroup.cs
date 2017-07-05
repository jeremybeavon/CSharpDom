namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup
    {
        public struct Struct : IInterfaceWithEvent
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
