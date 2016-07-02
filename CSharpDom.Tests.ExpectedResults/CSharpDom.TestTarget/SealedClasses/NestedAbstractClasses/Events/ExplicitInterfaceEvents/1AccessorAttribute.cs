namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedAbstractClassWithExplicitInterfaceEventWith1AccessorAttribute
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
