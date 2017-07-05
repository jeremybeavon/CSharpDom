namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedSealedPartialClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup
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
