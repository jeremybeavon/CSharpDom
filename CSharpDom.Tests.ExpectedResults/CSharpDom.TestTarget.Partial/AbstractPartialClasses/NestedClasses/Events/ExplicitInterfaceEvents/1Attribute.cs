namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public abstract partial class AbstractPartialClassWithNestedClassWithExplicitInterfaceEventWith1Attribute
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
