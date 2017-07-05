namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup
    {
        public event EventHandler Event
        {
            [Attribute1, Attribute2]
            add { }
            [Attribute1, Attribute2]
            remove { }
        }
    }
}
