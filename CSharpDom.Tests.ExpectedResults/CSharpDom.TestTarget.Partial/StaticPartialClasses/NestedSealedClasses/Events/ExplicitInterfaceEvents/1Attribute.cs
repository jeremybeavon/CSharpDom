namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public static partial class StaticPartialClassWithNestedSealedClassWithExplicitInterfaceEventWith1Attribute
    {
        public sealed class Class : IInterfaceWithEvent
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
