namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedPartialClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup
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
