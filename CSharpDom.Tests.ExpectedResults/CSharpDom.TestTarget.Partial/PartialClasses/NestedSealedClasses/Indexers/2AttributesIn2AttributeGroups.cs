namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Indexers
{
    public partial class PartialClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
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
