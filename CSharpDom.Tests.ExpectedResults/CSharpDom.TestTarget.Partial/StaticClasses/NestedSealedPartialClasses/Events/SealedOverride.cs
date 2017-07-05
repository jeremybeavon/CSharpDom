namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Events
{
    public static class StaticClassWithNestedSealedPartialClassWithSealedOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
