namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedClassWithExplicitInterfaceEventWithGenericInterface
    {
        public class Class : IGenericInterfaceWithEventWithGenericDelegate<EventArgs>
        {
            event EventHandler<EventArgs> IGenericInterfaceWithEventWithGenericDelegate<EventArgs>.Event
            {
                add { }
                remove { }
            }
        }
    }
}
