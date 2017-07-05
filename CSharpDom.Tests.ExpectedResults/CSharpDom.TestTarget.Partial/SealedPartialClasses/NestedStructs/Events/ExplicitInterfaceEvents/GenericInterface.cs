namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithNestedStructWithExplicitInterfaceEventWithGenericInterface
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
