namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithNestedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
    {
        public class Class : IInterfaceWithEvent
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
