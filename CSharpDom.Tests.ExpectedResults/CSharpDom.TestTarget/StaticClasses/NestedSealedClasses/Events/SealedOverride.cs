namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events
{
    public static class StaticClassWithNestedSealedClassWithSealedOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
