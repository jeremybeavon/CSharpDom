namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Events.ExplicitInterfaceEvents
{
    public partial struct PartialStructWithWithNestedClassWithExplicitInterfaceEventWith1AccessorAttribute
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
