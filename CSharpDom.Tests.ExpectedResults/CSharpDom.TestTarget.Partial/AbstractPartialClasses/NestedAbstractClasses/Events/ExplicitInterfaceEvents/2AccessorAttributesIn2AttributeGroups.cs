namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups
    {
        public abstract class Class : IInterfaceWithEvent
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
