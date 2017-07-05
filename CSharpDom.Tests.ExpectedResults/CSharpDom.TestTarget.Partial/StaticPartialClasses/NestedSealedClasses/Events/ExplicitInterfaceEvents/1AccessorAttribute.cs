namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public static partial class StaticPartialClassWithNestedSealedClassWithExplicitInterfaceEventWith1AccessorAttribute
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
