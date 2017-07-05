namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithNestedSealedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup
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
