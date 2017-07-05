namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedPartialClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups
    {
        public class Class : IInterfaceWithEvent
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
