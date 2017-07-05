namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup
    {
        public abstract class Class : IInterfaceWithEvent
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
