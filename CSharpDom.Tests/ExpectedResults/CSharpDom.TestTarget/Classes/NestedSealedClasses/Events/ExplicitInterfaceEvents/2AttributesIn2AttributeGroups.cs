namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Events.ExplicitInterfaceEvents
{
    public class ClassWithNestedSealedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
    {
        public sealed class Class : IInterfaceWithEvent
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
