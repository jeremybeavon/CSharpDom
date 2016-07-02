namespace CSharpDom.TestTarget.SealedClasses.Events
{
    public sealed class SealedClassWithOverrideEvent : BaseClassWithEvent
    {
        public override event EventHandler Event;
    }
}
