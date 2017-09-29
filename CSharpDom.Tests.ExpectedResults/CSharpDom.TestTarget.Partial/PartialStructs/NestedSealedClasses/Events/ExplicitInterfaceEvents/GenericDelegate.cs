namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public partial struct PartialStructWithNestedSealedClassWithExplicitInterfaceEventWithGenericDelegate
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
