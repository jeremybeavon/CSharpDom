namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedStructWithExplicitInterfaceEventWithGenericDelegate
    {
        public struct Struct : IInterfaceWithEventWithGenericDelegate
        {
            event EventHandler<EventArgs> IInterfaceWithEventWithGenericDelegate.Event
            {
                add { }
                remove { }
            }
        }
    }
}
