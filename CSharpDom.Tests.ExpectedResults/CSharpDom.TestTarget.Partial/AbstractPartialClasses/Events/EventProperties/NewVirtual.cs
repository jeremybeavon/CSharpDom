namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNewVirtualEventProperty : BaseClassWithEvent
    {
        public new virtual event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
