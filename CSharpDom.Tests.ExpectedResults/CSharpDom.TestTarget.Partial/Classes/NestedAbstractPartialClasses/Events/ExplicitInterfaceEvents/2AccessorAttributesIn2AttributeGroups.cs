namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedAbstractPartialClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups
    {
        public abstract class Class : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                [Attribute1]
                [Attribute2]
                add { }
                [Attribute1]
                [Attribute2]
                remove { }
            }
        }
    }
}
