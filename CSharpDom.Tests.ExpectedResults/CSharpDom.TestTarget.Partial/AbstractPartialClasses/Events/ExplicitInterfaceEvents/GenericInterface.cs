namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public abstract partial class AbstractPartialClassWithExplicitInterfaceEventWithGenericInterface : IGenericInterfaceWithEventWithGenericDelegate<EventArgs>
    {
        event EventHandler<EventArgs> IGenericInterfaceWithEventWithGenericDelegate<EventArgs>.Event
        {
            add { }
            remove { }
        }
    }
}
