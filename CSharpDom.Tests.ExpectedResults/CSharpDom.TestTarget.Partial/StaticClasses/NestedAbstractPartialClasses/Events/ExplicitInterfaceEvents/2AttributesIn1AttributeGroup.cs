namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedAbstractPartialClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup
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
