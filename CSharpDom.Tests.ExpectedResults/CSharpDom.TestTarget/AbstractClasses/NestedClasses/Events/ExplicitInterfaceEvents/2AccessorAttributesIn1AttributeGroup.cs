namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup
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
