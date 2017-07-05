namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithSealedOverrideEventProperty : BaseClassWithEvent
    {
        public sealed override event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
