namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithExplicitInterfaceEventWith1AccessorAttribute
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
