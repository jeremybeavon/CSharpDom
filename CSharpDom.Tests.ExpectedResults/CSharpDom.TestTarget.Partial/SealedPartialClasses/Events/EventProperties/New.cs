namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNewEventProperty : BaseClassWithEvent
    {
        public new event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
