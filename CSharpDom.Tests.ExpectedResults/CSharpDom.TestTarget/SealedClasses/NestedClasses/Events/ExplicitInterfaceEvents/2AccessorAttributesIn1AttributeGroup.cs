namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup
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
