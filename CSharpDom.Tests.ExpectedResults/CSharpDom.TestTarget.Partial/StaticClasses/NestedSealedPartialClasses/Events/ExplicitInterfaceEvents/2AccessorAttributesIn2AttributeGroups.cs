namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedSealedPartialClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups
    {
        public sealed class Class : IInterfaceWithEvent
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
