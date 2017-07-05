namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups
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
