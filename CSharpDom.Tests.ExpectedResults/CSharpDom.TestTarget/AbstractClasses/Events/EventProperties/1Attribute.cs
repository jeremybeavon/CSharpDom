namespace CSharpDom.TestTarget.AbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithEventPropertyWith1Attribute
    {
        [Attribute1]
        public event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
