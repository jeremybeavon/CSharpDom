namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Events.ExplicitInterfaceEvents
{
    public partial struct PartialStructWithWithNestedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup
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
