namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Indexers
{
    public partial struct PartialStructWithWithNestedAbstractClassWithIndexerWith2ParametersWithAttributes
    {
        public abstract class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
