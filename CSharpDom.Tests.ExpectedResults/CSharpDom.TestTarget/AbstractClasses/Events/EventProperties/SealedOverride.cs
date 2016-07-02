namespace CSharpDom.TestTarget.AbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithSealedOverrideEventProperty : BaseClassWithEvent
    {
        public sealed override event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
