namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNewEventProperty : BaseClassWithEvent
    {
        public new event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
