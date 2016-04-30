namespace CSharpDom.TestTarget.Structs.NestedClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedClassWithExplicitInterfaceEventWith1Attribute
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
