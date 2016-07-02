namespace CSharpDom.TestTarget.AbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithOverrideEventProperty : BaseClassWithEvent
    {
        public override event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
