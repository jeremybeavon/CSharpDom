namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithExplicitInterfaceEventWith1Attribute : IInterfaceWithEvent
    {
        [Attribute1]
        event EventHandler IInterfaceWithEvent.Event
        {
            add { }
            remove { }
        }
    }
}
