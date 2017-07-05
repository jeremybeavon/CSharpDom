namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Indexers
{
    public partial struct PartialStructWithWithNestedSealedClassWithIndexerWithWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
