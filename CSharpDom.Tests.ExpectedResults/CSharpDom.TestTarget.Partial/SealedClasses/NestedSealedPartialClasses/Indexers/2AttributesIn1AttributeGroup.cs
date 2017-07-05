namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Indexers
{
    public sealed class SealedClassWithNestedSealedPartialClassWithIndexerWithWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [Attribute1, Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
