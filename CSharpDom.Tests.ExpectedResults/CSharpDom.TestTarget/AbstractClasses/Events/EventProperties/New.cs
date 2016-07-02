namespace CSharpDom.TestTarget.AbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNewEventProperty : BaseClassWithEvent
    {
        public new event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
