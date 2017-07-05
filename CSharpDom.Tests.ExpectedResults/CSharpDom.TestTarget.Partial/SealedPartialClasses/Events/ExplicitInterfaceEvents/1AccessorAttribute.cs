namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithExplicitInterfaceEventWith1AccessorAttribute : IInterfaceWithEvent
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
