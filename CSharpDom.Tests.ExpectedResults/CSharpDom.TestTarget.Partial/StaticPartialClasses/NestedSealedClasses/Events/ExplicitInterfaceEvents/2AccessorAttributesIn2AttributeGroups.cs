namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public static partial class StaticPartialClassWithNestedSealedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups
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
