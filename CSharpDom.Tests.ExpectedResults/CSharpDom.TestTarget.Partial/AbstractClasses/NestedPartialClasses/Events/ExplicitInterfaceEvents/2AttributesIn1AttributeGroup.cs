namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Events.ExplicitInterfaceEvents
{
    public abstract class AbstractClassWithNestedPartialClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup
    {
        public class Class : IInterfaceWithEvent
        {
            [Attribute1, Attribute2]
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
