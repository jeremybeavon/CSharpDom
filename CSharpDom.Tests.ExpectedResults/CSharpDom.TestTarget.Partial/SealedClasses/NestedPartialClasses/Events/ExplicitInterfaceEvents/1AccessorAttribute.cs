namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public sealed class SealedClassWithNestedPartialClassWithExplicitInterfaceEventWith1AccessorAttribute
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
