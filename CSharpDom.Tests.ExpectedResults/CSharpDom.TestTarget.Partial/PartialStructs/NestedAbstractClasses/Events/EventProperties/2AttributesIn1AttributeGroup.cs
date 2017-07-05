namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
