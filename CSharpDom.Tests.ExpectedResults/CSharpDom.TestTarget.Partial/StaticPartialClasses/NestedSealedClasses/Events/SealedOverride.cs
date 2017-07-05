namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Events
{
    public static partial class StaticPartialClassWithNestedSealedClassWithSealedOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
