namespace CSharpDom.TestTarget.AbstractClasses.Events
{
    public abstract class AbstractClassWithSealedOverrideEvent : BaseClassWithEvent
    {
        public sealed override event EventHandler Event;
    }
}
