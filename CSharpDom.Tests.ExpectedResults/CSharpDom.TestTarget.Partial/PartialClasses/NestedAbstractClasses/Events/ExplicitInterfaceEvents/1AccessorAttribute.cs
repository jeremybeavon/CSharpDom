namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithNestedAbstractClassWithExplicitInterfaceEventWith1AccessorAttribute
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
