namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events
{
    public sealed class SealedClassWithNestedSealedClassWithNewStaticEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
