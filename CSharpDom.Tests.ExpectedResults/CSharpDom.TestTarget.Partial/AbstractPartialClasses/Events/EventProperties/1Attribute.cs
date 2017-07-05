namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithEventPropertyWith1Attribute
    {
        [Attribute1]
        public event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
