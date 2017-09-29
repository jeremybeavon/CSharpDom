namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Indexers
{
    public sealed partial class SealedPartialClassWithNestedStructWithIndexerWith2AccessorAttributesIn1AttributeGroup
    {
        public struct Struct
        {
            public string this[int index]
            {
                [Attribute1, Attribute2]
                get { return default(string); }
                [Attribute1, Attribute2]
                set { }
            }
        }
    }
}
