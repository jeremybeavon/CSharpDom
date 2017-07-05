namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithExplicitInterfaceEventWithGenericInterface
    {
        public abstract class Class : IGenericInterfaceWithEventWithGenericDelegate<EventArgs>
        {
            event EventHandler<EventArgs> IGenericInterfaceWithEventWithGenericDelegate<EventArgs>.Event
            {
                add { }
                remove { }
            }
        }
    }
}
