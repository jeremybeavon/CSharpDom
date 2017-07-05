namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNewEventProperty
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
