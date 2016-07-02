namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedAbstractClassWithExplicitInterfaceEventWithGenericInterface
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
