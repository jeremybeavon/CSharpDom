namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Indexers
{
    public struct StructWithNestedSealedClassWithPublicIndexer
    {
        public sealed class Class
        {
            public string this[int index]
            {
                set { }
            }
        }
    }
}
