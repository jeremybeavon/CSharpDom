namespace CSharpDom.TestTarget.SealedClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithExplicitInterfaceEventWithGenericInterface : IGenericInterfaceWithEventWithGenericDelegate<EventArgs>
    {
        event EventHandler<EventArgs> IGenericInterfaceWithEventWithGenericDelegate<EventArgs>.Event
        {
            add { }
            remove { }
        }
    }
}
