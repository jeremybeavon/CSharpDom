namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Indexers
{
    public partial struct PartialStructWithWithNestedSealedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            public string this[int index]
            {
                [Attribute1, Attribute2]
                get { return default(string); }
                [Attribute1, Attribute2]
                set { }
            }
        }
    }
}
