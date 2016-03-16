namespace CSharpDom.TestTarget.SealedClasses.Events
{
    public sealed class SealedClassWithSealedOverrideEvent : BaseClassWithEvent
    {
        public sealed override event EventHandler Event;
    }
}
