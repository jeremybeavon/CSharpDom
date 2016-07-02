namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedSealedClassWithExplicitInterfaceEventWith1AccessorAttribute
    {
        public sealed class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                [Attribute1]
                add { }
                [Attribute1]
                remove { }
            }
        }
    }
}
