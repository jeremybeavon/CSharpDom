namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithExplicitInterfaceEventWith1AccessorAttribute
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
