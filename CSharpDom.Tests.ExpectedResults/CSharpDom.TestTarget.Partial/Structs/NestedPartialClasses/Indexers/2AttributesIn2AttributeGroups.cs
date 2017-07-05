namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Indexers
{
    public struct StructWithNestedPartialClassWithIndexerWith2AttributesIn2AttributeGroups
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
