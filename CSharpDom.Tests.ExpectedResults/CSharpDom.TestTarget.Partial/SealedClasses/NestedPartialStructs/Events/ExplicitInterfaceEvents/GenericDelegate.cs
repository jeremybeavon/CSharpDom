namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedStructWithExplicitInterfaceEventWithGenericDelegate
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
