namespace CSharpDom.TestTarget.Partial.PartialClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithExplicitInterfaceEventWith1AccessorAttribute : IInterfaceWithEvent
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
