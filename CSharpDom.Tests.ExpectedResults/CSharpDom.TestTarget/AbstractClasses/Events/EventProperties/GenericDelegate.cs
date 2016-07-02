namespace CSharpDom.TestTarget.AbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithEventPropertyWithGenericDelegate
    {
        public event EventHandler<EventArgs> Event
        {
            add { }
            remove { }
        }
    }
}
