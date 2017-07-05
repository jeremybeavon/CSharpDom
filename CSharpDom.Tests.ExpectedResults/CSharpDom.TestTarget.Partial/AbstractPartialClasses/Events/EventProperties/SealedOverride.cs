namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithSealedOverrideEventProperty : BaseClassWithEvent
    {
        public sealed override event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
