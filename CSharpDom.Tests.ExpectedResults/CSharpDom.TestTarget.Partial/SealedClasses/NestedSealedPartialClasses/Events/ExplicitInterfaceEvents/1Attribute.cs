namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedSealedPartialClassWithExplicitInterfaceEventWith1Attribute
    {
        public sealed class Class : IInterfaceWithEvent
        {
            [Attribute1]
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
