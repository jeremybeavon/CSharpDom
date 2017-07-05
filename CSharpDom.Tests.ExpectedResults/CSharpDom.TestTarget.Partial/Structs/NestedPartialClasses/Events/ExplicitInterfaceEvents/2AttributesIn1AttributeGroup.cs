namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedPartialClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup
    {
        public class Class : IInterfaceWithEvent
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
