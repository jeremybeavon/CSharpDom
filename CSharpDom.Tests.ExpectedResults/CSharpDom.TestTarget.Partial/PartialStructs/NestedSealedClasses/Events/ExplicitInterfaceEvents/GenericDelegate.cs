namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public partial struct PartialStructWithWithNestedSealedClassWithExplicitInterfaceEventWithGenericDelegate
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
