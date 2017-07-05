namespace CSharpDom.TestTarget.Partial.PartialClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups : IInterfaceWithEvent
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
