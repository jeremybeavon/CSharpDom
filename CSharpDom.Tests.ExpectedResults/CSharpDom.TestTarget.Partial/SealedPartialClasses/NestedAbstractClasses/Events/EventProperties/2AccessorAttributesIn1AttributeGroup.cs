namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup
    {
        public abstract class Class
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
}
