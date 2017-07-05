namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithNestedClassWithExplicitInterfaceEventWithGenericDelegate
    {
        public class Class : IInterfaceWithEventWithGenericDelegate
        {
            event EventHandler<EventArgs> IInterfaceWithEventWithGenericDelegate.Event
            {
                add { }
                remove { }
            }
        }
    }
}
