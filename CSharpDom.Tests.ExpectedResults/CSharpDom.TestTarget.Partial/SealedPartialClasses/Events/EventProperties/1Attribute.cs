namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithEventPropertyWith1Attribute
    {
        [Attribute1]
        public event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
