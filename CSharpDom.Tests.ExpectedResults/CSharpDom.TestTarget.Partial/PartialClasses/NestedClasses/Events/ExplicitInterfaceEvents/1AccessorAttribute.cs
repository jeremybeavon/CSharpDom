namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithNestedClassWithExplicitInterfaceEventWith1AccessorAttribute
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
