namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Events
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
