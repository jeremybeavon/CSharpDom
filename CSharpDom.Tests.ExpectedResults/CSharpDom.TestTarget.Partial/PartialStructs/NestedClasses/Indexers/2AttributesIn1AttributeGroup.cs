namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Indexers
{
    public partial struct PartialStructWithWithNestedClassWithIndexerWithWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
