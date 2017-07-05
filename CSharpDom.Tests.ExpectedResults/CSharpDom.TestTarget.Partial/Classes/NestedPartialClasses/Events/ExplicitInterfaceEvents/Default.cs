namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedPartialClassWithExplicitInterfaceEvent
    {
        public class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
