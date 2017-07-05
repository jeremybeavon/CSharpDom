namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedPartialClassWithExplicitInterfaceEventWithGenericDelegate
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
