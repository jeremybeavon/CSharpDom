namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Indexers
{
    public sealed partial class SealedPartialClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups
    {
        public struct Struct
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
