namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithNestedStructWithExplicitInterfaceEventWithGenericDelegate
    {
        public struct Struct : IInterfaceWithEventWithGenericDelegate
        {
            event EventHandler<EventArgs> IInterfaceWithEventWithGenericDelegate.Event
            {
                add { }
                remove { }
            }
        }
    }
}
