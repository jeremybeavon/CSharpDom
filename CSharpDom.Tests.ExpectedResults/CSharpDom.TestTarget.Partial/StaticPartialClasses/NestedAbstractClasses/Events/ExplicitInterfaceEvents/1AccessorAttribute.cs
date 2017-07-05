namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithExplicitInterfaceEventWith1AccessorAttribute
    {
        public abstract class Class : IInterfaceWithEvent
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
