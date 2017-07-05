namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithNestedSealedClassWithExplicitInterfaceEventWith1AccessorAttribute
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
