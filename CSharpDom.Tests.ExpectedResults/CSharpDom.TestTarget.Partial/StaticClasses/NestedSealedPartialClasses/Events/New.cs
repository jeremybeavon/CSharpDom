namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Events
{
    public static class StaticClassWithNestedSealedPartialClassWithNewEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
