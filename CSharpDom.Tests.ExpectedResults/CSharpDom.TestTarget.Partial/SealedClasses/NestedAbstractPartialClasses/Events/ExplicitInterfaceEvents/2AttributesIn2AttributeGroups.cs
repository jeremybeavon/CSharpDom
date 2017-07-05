namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
    {
        public abstract class Class : IInterfaceWithEvent
        {
            [Attribute1]
            [Attribute2]
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
