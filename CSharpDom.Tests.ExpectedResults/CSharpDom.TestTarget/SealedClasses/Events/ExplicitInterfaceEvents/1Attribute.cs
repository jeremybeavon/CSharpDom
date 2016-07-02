namespace CSharpDom.TestTarget.SealedClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithExplicitInterfaceEventWith1Attribute : IInterfaceWithEvent
    {
        [Attribute1]
        event EventHandler IInterfaceWithEvent.Event
        {
            add { }
            remove { }
        }
    }
}
