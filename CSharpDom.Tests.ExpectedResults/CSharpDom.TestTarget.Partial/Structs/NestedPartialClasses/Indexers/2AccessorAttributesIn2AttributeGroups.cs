namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Indexers
{
    public struct StructWithNestedPartialClassWithIndexerWith2AccessorAttributesIn2AttributeGroups
    {
        public partial class Class
        {
            public string this[int index]
            {
                [Attribute1]
                [Attribute2]
                get { return default(string); }
                [Attribute1]
                [Attribute2]
                set { }
            }
        }
    }
}
