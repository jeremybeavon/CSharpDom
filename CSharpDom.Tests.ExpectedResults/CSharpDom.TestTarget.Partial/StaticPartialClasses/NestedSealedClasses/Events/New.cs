namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Events
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNewEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
