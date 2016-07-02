namespace CSharpDom.TestTarget.AbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithPrivateEventProperty
    {
        private event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
