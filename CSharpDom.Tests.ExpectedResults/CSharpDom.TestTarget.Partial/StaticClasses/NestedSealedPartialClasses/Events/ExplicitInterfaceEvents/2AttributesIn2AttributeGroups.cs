namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedSealedPartialClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
    {
        public sealed class Class : IInterfaceWithEvent
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
