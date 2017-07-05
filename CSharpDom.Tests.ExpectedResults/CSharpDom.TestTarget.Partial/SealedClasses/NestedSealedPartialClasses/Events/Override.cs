namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Events
{
    public sealed class SealedClassWithNestedSealedPartialClassWithOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
