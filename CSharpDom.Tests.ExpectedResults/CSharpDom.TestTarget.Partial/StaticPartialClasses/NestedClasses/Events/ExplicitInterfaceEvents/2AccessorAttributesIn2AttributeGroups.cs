namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public static partial class StaticPartialClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups
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
