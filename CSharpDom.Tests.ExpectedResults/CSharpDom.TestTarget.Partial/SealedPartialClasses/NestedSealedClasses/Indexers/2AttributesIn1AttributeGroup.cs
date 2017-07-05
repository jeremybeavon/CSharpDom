namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Indexers
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithIndexerWithWith2AttributesIn1AttributeGroup
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
