namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedPartialClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
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
