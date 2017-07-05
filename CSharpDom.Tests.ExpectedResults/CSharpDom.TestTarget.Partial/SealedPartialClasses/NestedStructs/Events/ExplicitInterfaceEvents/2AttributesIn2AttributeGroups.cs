namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
    {
        public struct Struct : IInterfaceWithEvent
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
