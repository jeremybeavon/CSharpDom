namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedStructWithExplicitInterfaceEventWithGenericDelegate
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
