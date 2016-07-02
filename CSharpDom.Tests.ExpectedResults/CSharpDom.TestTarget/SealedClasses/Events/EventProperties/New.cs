namespace CSharpDom.TestTarget.SealedClasses.Events.EventProperties
{
    public sealed class SealedClassWithNewEventProperty : BaseClassWithEvent
    {
        public new event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
