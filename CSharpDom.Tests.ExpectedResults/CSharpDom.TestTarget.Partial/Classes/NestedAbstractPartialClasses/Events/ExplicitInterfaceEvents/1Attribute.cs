namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedAbstractPartialClassWithExplicitInterfaceEventWith1Attribute
    {
        public abstract class Class : IInterfaceWithEvent
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
