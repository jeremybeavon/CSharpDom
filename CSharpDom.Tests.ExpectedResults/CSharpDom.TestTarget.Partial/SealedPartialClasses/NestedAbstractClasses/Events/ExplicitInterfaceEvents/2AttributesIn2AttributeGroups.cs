namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
    {
        public abstract class Class : IInterfaceWithEvent
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
