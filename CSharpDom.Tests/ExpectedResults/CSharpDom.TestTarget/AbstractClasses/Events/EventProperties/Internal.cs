namespace CSharpDom.TestTarget.AbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithInternalEventProperty
    {
        internal event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
