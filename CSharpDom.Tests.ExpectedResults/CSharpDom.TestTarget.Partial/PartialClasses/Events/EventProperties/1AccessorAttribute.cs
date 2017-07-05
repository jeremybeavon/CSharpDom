namespace CSharpDom.TestTarget.Partial.PartialClasses.Events.EventProperties
{
    public partial class PartialClassWithEventPropertyWith1AccessorAttribute
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
