namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithOverrideEventProperty : BaseClassWithEvent
    {
        public override event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
