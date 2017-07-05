namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNewEventProperty
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
