namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Events
{
    public abstract partial class AbstractPartialClassWithSealedOverrideEvent : BaseClassWithEvent
    {
        public sealed override event EventHandler Event;
    }
}
