namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events
{
    public sealed class SealedClassWithNestedSealedClassWithSealedOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
