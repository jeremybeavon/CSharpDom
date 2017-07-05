namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithNestedSealedClassWithExplicitInterfaceEventWithGenericInterface
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
