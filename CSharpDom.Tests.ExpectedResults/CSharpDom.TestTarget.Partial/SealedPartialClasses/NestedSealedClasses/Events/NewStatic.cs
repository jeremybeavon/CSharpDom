namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Events
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNewStaticEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
