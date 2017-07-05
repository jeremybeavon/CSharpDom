namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
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
