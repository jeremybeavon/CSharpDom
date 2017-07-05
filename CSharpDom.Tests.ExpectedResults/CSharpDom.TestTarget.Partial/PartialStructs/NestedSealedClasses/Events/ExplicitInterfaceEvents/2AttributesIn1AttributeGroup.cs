namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public partial struct PartialStructWithWithNestedSealedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup
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
