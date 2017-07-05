namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedStructWithExplicitInterfaceEventWith1Attribute
    {
        public struct Struct : IInterfaceWithEvent
        {
            [Attribute1]
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
