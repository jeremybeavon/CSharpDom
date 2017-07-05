namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup
    {
        public abstract class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                [Attribute1, Attribute2]
                add { }
                [Attribute1, Attribute2]
                remove { }
            }
        }
    }
}
