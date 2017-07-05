namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedAbstractPartialClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup
    {
        public abstract class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                [Attribute1, Attribute2]
                add { }
                [Attribute1, Attribute2]
                remove { }
            }
        }
    }
}
