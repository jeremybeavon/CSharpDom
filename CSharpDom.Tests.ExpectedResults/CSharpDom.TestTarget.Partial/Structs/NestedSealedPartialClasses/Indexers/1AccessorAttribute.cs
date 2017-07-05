namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Indexers
{
    public struct StructWithNestedSealedPartialClassWithIndexerWith1AccessorAttribute
    {
        public sealed partial class Class
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
