namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithEventPropertyWith1AccessorAttribute
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
