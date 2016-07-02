namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedSealedClassWithExplicitInterfaceEventWithGenericDelegate
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
