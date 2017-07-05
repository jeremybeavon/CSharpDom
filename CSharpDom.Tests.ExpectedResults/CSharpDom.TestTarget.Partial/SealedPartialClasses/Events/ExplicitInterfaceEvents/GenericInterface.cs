namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithExplicitInterfaceEventWithGenericInterface : IGenericInterfaceWithEventWithGenericDelegate<EventArgs>
    {
        event EventHandler<EventArgs> IGenericInterfaceWithEventWithGenericDelegate<EventArgs>.Event
        {
            add { }
            remove { }
        }
    }
}
