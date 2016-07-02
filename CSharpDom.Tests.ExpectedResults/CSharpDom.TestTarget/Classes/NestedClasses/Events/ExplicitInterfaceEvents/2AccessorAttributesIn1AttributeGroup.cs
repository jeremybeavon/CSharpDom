namespace CSharpDom.TestTarget.Classes.NestedClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup
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
