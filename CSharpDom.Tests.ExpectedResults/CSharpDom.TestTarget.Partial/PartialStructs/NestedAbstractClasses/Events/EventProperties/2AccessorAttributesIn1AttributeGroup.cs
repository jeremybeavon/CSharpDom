namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup
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
