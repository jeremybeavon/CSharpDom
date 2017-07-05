namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedStructWithExplicitInterfaceEventWith1AccessorAttribute
    {
        public struct Struct : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                [Attribute1]
                add { }
                [Attribute1]
                remove { }
            }
        }
    }
}
