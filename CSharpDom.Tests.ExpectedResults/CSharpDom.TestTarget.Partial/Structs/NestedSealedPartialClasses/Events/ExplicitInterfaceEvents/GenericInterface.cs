namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedSealedPartialClassWithExplicitInterfaceEventWithGenericInterface
    {
        public sealed class Class : IGenericInterfaceWithEventWithGenericDelegate<EventArgs>
        {
            event EventHandler<EventArgs> IGenericInterfaceWithEventWithGenericDelegate<EventArgs>.Event
            {
                add { }
                remove { }
            }
        }
    }
}
