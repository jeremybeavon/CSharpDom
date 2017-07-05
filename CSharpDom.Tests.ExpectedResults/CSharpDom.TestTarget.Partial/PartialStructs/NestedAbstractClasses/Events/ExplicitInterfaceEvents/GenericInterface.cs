namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public partial struct PartialStructWithWithNestedAbstractClassWithExplicitInterfaceEventWithGenericInterface
    {
        public abstract class Class : IGenericInterfaceWithEventWithGenericDelegate<EventArgs>
        {
            event EventHandler<EventArgs> IGenericInterfaceWithEventWithGenericDelegate<EventArgs>.Event
            {
                add { }
                remove { }
            }
        }
    }
}
