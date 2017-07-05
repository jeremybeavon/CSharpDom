namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedPartialClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
    {
        public class Class : IInterfaceWithEvent
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
