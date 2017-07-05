namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public abstract partial class AbstractPartialClassWithNestedStructWithExplicitInterfaceEventWithGenericInterface
    {
        public struct Struct : IGenericInterfaceWithEventWithGenericDelegate<EventArgs>
        {
            event EventHandler<EventArgs> IGenericInterfaceWithEventWithGenericDelegate<EventArgs>.Event
            {
                add { }
                remove { }
            }
        }
    }
}
