namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithExplicitInterfaceEventWithGenericInterface
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
