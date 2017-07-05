namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithExplicitInterfaceEventWith1Attribute
    {
        public abstract class Class : IInterfaceWithEvent
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
