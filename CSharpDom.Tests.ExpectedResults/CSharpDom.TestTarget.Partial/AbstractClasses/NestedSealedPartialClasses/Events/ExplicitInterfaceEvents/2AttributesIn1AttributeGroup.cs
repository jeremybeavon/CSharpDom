namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup
    {
        public sealed class Class : IInterfaceWithEvent
        {
            [Attribute1, Attribute2]
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
