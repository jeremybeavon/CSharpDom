namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public sealed partial class SealedPartialClassWithNestedClassWithExplicitInterfaceEventWith1AccessorAttribute
    {
        public class Class : IInterfaceWithEvent
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
