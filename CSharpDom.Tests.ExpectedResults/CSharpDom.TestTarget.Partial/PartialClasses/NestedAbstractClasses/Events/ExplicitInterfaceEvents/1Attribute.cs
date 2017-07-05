namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithNestedAbstractClassWithExplicitInterfaceEventWith1Attribute
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
