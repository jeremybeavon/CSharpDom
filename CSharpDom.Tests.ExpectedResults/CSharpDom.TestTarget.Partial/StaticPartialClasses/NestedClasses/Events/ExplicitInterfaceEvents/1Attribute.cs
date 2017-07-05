namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public static partial class StaticPartialClassWithNestedClassWithExplicitInterfaceEventWith1Attribute
    {
        public class Class : IInterfaceWithEvent
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
