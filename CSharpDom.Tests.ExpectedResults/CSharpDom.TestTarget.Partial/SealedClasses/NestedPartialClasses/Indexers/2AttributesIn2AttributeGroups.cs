namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Indexers
{
    public sealed class SealedClassWithNestedPartialClassWithIndexerWith2AttributesIn2AttributeGroups
    {
        public partial class Class
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
