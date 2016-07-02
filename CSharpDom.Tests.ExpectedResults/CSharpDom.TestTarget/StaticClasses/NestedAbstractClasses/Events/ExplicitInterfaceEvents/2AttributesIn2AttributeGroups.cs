namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public static class StaticClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups
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
