namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithEventPropertyWith1AccessorAttribute
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
