namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedSealedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups
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
