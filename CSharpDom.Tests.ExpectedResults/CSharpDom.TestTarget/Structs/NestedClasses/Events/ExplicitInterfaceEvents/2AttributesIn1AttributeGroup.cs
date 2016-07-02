namespace CSharpDom.TestTarget.Structs.NestedClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup
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
