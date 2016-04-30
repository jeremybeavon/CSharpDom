namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Indexers
{
    public struct StructWithNestedSealedClassWithInternalIndexer
    {
        public sealed class Class
        {
            internal string this[int index]
            {
                set { }
            }
        }
    }
}
