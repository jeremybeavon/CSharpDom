namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public abstract partial class AbstractPartialClassWithNestedStructWithExplicitInterfaceEventWith1AccessorAttribute
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
