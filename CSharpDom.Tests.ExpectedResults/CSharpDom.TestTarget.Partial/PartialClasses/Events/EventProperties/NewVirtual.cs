namespace CSharpDom.TestTarget.Partial.PartialClasses.Events.EventProperties
{
    public partial class PartialClassWithNewVirtualEventProperty : BaseClassWithEvent
    {
        public new virtual event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
