namespace CSharpDom.TestTarget.Partial.PartialClasses.Events.EventProperties
{
    public partial class PartialClassWithOverrideEventProperty : BaseClassWithEvent
    {
        public override event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
