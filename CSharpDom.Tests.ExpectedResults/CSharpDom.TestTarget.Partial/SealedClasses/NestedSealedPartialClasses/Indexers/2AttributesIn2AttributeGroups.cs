namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Indexers
{
    public sealed class SealedClassWithNestedSealedPartialClassWithIndexerWith2AttributesIn2AttributeGroups
    {
        public sealed partial class Class
        {
            [Attribute1]
            [Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
