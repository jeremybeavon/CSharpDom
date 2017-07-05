namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Indexers
{
    public sealed class SealedClassWithNestedStructWithIndexerWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
