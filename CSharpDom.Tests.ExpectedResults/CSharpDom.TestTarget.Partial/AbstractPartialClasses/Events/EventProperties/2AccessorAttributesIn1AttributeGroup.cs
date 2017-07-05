namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup
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
