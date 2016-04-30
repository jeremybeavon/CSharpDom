namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events
{
    public sealed class SealedClassWithNestedSealedClassWithOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
