namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedSealedPartialClassWithExplicitInterfaceEventWithGenericDelegate
    {
        public sealed class Class : IInterfaceWithEventWithGenericDelegate
        {
            event EventHandler<EventArgs> IInterfaceWithEventWithGenericDelegate.Event
            {
                add { }
                remove { }
            }
        }
    }
}
