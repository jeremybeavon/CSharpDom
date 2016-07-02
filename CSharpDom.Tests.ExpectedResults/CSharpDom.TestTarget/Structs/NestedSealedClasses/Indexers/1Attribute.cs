namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Indexers
{
    public struct StructWithNestedSealedClassWithIndexerWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
