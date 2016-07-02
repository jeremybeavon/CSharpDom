namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup
    {
        public class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                [Attribute1, Attribute2]
                add { }
                [Attribute1, Attribute2]
                remove { }
            }
        }
    }
}
