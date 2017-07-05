namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedSealedPartialClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup
    {
        public sealed class Class : IInterfaceWithEvent
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
