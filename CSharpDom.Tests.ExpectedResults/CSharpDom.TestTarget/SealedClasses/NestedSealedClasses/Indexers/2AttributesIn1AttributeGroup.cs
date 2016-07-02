namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Indexers
{
    public sealed class SealedClassWithNestedSealedClassWithIndexerWithWith2AttributesIn1AttributeGroup
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
