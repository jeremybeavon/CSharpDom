namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
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
