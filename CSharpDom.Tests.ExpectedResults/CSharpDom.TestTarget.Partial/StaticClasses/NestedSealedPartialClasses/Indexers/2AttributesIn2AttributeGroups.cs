namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Indexers
{
    public static class StaticClassWithNestedSealedPartialClassWithIndexerWith2AttributesIn2AttributeGroups
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
