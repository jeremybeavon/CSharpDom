namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Indexers
{
    public partial struct PartialStructWithWithNestedClassWithIndexerWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
