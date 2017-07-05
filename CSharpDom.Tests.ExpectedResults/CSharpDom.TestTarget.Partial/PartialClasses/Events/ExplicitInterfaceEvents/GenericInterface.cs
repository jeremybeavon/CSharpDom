namespace CSharpDom.TestTarget.Partial.PartialClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithExplicitInterfaceEventWithGenericInterface : IGenericInterfaceWithEventWithGenericDelegate<EventArgs>
    {
        event EventHandler<EventArgs> IGenericInterfaceWithEventWithGenericDelegate<EventArgs>.Event
        {
            add { }
            remove { }
        }
    }
}
