namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedPartialClassWithExplicitInterfaceEventWithGenericInterface
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
