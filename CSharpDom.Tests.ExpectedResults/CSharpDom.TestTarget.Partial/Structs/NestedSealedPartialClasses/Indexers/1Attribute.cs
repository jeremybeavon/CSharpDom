namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Indexers
{
    public struct StructWithNestedSealedPartialClassWithIndexerWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
