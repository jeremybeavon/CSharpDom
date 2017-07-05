namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Events.ExplicitInterfaceEvents
{
    public partial class PartialClassWithNestedStructWithExplicitInterfaceEvent
    {
        public struct Struct : IInterfaceWithEvent
        {
            event EventHandler IInterfaceWithEvent.Event
            {
                add { }
                remove { }
            }
        }
    }
}
