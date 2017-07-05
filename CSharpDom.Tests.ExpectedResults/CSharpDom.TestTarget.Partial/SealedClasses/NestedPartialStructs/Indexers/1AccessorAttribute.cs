namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Indexers
{
    public sealed class SealedClassWithNestedStructWithIndexerWith1AccessorAttribute
    {
        public struct Struct
        {
            public string this[int index]
            {
                [Attribute1]
                get { return default(string); }
                [Attribute1]
                set { }
            }
        }
    }
}
