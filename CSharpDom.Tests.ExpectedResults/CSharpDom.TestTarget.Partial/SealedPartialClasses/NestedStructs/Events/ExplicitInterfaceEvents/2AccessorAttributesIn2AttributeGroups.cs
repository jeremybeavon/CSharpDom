namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups
    {
        public struct Struct : IInterfaceWithEvent
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
