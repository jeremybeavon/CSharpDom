namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithOverrideEventProperty : BaseClassWithEvent
    {
        public override event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
