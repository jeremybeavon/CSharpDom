namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedPartialClassWithExplicitInterfaceEventWith1AccessorAttribute
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
