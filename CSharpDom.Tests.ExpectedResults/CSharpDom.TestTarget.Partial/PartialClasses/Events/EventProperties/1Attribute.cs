namespace CSharpDom.TestTarget.Partial.PartialClasses.Events.EventProperties
{
    public partial class PartialClassWithEventPropertyWith1Attribute
    {
        [Attribute1]
        public event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
