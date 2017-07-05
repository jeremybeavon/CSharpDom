namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup
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
