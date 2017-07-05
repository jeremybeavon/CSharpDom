namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public abstract partial class AbstractPartialClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup
    {
        public class Class : IInterfaceWithEvent
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
