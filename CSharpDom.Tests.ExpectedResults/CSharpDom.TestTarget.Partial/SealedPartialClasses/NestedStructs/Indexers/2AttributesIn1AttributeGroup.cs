namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Indexers
{
    public sealed partial class SealedPartialClassWithNestedStructWithIndexerWithWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
