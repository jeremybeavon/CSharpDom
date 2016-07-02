namespace CSharpDom.TestTarget.AbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNewStaticEventProperty : BaseClassWithEvent
    {
        public new static event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
