namespace CSharpDom.TestTarget.Partial.PartialClasses.Events.EventProperties
{
    public partial class PartialClassWithSealedOverrideEventProperty : BaseClassWithEvent
    {
        public sealed override event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
