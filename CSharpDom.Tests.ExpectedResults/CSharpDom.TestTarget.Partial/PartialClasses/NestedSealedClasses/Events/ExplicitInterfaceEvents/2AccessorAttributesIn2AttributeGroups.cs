namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithNestedSealedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups
    {
        public sealed class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                [Attribute1]
                [Attribute2]
                add { }
                [Attribute1]
                [Attribute2]
                remove { }
            }
        }
    }
}
