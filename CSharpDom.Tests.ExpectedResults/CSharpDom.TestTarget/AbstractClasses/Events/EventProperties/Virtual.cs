namespace CSharpDom.TestTarget.AbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithVirtualEventProperty
    {
        public virtual event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
