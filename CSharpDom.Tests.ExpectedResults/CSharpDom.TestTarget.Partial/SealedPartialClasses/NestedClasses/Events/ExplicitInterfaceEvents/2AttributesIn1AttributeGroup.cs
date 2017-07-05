namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithNestedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup
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
