namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public static partial class StaticPartialClassWithNestedSealedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup
    {
        public sealed class Class : IInterfaceWithEvent
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
