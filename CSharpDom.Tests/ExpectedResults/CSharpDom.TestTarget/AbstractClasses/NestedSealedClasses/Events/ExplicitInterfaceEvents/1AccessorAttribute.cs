namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedSealedClassWithExplicitInterfaceEventWith1AccessorAttribute
    {
        public sealed class Class : IInterfaceWithEvent
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
