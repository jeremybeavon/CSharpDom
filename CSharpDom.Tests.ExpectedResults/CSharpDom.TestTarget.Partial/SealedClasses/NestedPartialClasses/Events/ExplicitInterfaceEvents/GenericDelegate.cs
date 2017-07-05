namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedPartialClassWithExplicitInterfaceEventWithGenericDelegate
    {
        public class Class : IInterfaceWithEventWithGenericDelegate
        {
            event EventHandler<EventArgs> IInterfaceWithEventWithGenericDelegate.Event
            {
                add { }
                remove { }
            }
        }
    }
}
