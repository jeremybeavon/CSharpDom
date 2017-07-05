namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
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
