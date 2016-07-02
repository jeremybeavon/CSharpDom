namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedSealedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
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
