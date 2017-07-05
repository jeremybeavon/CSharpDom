namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public abstract partial class AbstractPartialClassWithNestedStructWithExplicitInterfaceEventWithGenericDelegate
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
