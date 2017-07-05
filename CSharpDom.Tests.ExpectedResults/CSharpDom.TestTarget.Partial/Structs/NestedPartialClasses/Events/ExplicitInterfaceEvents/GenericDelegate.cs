namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedPartialClassWithExplicitInterfaceEventWithGenericDelegate
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
