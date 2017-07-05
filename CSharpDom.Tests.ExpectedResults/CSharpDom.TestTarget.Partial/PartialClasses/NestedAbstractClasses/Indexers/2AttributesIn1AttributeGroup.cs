namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Indexers
{
    public partial class PartialClassWithNestedAbstractClassWithIndexerWithWith2AttributesIn1AttributeGroup
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
