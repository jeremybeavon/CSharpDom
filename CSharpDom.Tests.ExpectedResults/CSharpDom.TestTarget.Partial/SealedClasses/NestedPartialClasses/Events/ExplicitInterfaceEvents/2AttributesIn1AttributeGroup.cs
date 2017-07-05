namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedPartialClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup
    {
        public class Class : IInterfaceWithEvent
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
