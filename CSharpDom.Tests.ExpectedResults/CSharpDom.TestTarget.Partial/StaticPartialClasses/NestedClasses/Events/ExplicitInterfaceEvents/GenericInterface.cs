namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Events.ExplicitInterfaceEvents
{
    public static partial class StaticPartialClassWithNestedClassWithExplicitInterfaceEventWithGenericInterface
    {
        public class Class : IGenericInterfaceWithEventWithGenericDelegate<EventArgs>
        {
            event EventHandler<EventArgs> IGenericInterfaceWithEventWithGenericDelegate<EventArgs>.Event
            {
                add { }
                remove { }
            }
        }
    }
}
