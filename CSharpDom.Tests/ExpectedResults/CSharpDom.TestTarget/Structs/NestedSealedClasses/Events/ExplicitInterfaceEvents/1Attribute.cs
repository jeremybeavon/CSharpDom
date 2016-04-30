namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public struct StructWithNestedSealedClassWithExplicitInterfaceEventWith1Attribute
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
