namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Indexers
{
    public struct StructWithNestedSealedClassWithProtectedInternalIndexer
    {
        public sealed class Class
        {
            protected internal string this[int index]
            {
                set { }
            }
        }
    }
}
