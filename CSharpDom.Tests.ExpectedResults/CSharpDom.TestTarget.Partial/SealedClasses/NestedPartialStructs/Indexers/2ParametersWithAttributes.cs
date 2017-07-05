namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Indexers
{
    public sealed class SealedClassWithNestedStructWithIndexerWith2ParametersWithAttributes
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
