namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public abstract partial class AbstractPartialClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup
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
