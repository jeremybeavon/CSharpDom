namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNewStaticEventProperty : BaseClassWithEvent
    {
        public new static event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
