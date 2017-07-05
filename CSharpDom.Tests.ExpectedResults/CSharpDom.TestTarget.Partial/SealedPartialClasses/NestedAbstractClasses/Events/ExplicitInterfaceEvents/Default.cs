namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithExplicitInterfaceEvent
    {
        public abstract class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
