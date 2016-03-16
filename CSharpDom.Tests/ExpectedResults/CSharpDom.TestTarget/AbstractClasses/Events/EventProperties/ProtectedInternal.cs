namespace CSharpDom.TestTarget.AbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithProtectedInternalEventProperty
    {
        protected internal event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
