namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedSealedClassWithExplicitInterfaceEventWith1Attribute
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
