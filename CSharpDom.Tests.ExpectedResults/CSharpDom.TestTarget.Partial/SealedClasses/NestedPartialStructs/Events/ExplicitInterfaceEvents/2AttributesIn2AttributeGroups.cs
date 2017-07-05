namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
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
