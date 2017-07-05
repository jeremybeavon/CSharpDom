namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Indexers
{
    public partial struct PartialStructWithWithNestedAbstractClassWithIndexerWithWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
