namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Indexers
{
    public partial struct PartialStructWithWithNestedClassWithIndexerWith2ParametersWithAttributes
    {
        public class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
