namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithExplicitInterfaceEventWithGenericInterface
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
