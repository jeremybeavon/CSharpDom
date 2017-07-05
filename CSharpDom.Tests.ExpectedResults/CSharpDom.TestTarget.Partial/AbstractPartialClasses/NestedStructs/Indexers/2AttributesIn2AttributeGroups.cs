namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups
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
