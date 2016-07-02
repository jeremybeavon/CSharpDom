namespace CSharpDom.TestTarget.Classes.NestedClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedClassWithExplicitInterfaceEventWith1Attribute
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
