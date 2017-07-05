namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedPartialClassWithExplicitInterfaceEventWithGenericInterface
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
