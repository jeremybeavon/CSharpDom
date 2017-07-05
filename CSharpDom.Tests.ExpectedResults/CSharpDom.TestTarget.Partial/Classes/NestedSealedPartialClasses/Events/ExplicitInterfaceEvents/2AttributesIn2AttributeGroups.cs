namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedSealedPartialClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
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
