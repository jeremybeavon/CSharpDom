namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedAbstractPartialClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
    {
        public abstract class Class : IInterfaceWithEvent
        {
            [Attribute1]
            [Attribute2]
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
