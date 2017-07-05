namespace CSharpDom.TestTarget.Partial.PartialClasses.Events.EventProperties
{
    public partial class PartialClassWithNewStaticEventProperty : BaseClassWithEvent
    {
        public new static event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
