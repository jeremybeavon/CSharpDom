namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedSealedPartialClassWithExplicitInterfaceEventWithGenericDelegate
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
