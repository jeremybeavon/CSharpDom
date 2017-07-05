namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
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
