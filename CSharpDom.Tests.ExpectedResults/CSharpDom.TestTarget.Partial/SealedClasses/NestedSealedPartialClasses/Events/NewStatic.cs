namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Events
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNewStaticEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
