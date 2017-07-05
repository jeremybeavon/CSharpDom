namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Indexers
{
    public sealed class SealedClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups
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
