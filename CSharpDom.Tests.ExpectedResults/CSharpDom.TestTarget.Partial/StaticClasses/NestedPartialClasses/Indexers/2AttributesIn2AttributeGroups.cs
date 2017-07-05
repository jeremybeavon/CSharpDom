namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Indexers
{
    public static class StaticClassWithNestedPartialClassWithIndexerWith2AttributesIn2AttributeGroups
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
