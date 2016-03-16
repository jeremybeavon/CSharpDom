namespace CSharpDom.TestTarget.SealedClasses.Events
{
    public sealed class SealedClassWithNewStaticEvent : BaseClassWithEvent
    {
        public new static event EventHandler Event;
    }
}
