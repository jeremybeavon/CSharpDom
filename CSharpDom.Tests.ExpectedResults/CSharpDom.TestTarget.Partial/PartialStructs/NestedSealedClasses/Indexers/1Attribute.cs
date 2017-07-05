namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Indexers
{
    public partial struct PartialStructWithWithNestedSealedClassWithIndexerWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
