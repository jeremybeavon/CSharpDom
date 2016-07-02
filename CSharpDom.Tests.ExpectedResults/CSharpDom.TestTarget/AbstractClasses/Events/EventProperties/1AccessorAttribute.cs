namespace CSharpDom.TestTarget.AbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithEventPropertyWith1AccessorAttribute
    {
        public event EventHandler Event
        {
            [Attribute1]
            add { }
            [Attribute1]
            remove { }
        }
    }
}
