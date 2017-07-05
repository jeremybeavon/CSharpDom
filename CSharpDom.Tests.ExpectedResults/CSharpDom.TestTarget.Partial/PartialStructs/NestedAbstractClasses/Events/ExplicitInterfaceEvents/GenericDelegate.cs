namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public partial struct PartialStructWithWithNestedAbstractClassWithExplicitInterfaceEventWithGenericDelegate
    {
        public abstract class Class : IInterfaceWithEventWithGenericDelegate
        {
            event EventHandler<EventArgs> IInterfaceWithEventWithGenericDelegate.Event
            {
                add { }
                remove { }
            }
        }
    }
}
