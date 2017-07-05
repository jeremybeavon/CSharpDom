namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedAbstractPartialClassWithExplicitInterfaceEventWithGenericInterface
    {
        public abstract class Class : IGenericInterfaceWithEventWithGenericDelegate<EventArgs>
        {
            event EventHandler<EventArgs> IGenericInterfaceWithEventWithGenericDelegate<EventArgs>.Event
            {
                add { }
                remove { }
            }
        }
    }
}
