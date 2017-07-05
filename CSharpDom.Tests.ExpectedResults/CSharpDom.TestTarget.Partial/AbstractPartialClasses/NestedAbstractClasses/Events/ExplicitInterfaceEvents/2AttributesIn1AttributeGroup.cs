namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup
    {
        public abstract class Class : IInterfaceWithEvent
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
