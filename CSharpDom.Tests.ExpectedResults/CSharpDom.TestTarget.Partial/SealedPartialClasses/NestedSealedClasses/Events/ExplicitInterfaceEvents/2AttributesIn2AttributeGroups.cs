namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
    {
        public sealed class Class : IInterfaceWithEvent
        {
            [Attribute1]
            [Attribute2]
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
