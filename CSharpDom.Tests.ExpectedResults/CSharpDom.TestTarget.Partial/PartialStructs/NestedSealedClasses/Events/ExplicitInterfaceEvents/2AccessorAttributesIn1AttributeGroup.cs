namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public partial struct PartialStructWithWithNestedSealedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup
    {
        public sealed class Class : IInterfaceWithEvent
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
