namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedSealedClassWithExplicitInterfaceEventWith1Attribute
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
