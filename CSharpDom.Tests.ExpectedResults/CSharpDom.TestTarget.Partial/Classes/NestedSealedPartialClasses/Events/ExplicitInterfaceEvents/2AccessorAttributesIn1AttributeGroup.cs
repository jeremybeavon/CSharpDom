namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedSealedPartialClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup
    {
        public sealed class Class : IInterfaceWithEvent
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
