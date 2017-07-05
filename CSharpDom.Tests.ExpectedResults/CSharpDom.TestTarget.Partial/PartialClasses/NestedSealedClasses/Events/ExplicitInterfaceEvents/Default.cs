namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithNestedSealedClassWithExplicitInterfaceEvent
    {
        public sealed class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
