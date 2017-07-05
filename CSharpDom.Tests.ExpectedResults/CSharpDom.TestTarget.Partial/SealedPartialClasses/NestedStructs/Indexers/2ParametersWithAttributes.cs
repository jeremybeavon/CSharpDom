namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Indexers
{
    public sealed partial class SealedPartialClassWithNestedStructWithIndexerWith2ParametersWithAttributes
    {
        public struct Struct
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
