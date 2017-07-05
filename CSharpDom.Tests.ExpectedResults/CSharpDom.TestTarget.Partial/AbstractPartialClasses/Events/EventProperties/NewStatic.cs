namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNewStaticEventProperty : BaseClassWithEvent
    {
        public new static event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
