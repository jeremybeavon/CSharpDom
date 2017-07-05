namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
