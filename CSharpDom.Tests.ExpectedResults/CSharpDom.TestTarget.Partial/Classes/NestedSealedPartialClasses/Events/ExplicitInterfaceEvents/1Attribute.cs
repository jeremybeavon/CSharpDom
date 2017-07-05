namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedSealedPartialClassWithExplicitInterfaceEventWith1Attribute
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
