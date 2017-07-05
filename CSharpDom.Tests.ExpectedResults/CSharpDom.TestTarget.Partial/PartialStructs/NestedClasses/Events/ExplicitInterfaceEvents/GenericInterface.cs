namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Events.ExplicitInterfaceEvents
{
    public partial struct PartialStructWithWithNestedClassWithExplicitInterfaceEventWithGenericInterface
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
