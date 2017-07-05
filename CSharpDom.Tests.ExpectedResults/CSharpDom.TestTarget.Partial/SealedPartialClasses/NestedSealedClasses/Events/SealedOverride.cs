namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Events
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithSealedOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
