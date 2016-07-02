namespace CSharpDom.TestTarget.SealedClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithExplicitInterfaceEventWith1AccessorAttribute : IInterfaceWithEvent
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
