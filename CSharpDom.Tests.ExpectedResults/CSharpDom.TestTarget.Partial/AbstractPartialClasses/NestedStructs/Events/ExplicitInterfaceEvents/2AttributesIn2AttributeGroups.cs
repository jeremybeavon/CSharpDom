namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public abstract partial class AbstractPartialClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
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
