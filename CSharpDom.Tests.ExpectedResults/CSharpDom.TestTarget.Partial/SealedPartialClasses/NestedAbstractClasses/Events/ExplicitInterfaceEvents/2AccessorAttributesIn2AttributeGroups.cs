namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups
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
