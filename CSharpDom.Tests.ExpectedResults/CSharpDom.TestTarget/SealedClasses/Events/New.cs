namespace CSharpDom.TestTarget.SealedClasses.Events
{
    public sealed class SealedClassWithNewEvent : BaseClassWithEvent
    {
        public new event EventHandler Event;
    }
}
