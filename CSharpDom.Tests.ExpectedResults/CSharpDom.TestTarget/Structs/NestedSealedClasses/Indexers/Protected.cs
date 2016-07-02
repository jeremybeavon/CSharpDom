namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Indexers
{
    public struct StructWithNestedSealedClassWithProtectedIndexer
    {
        public sealed class Class
        {
            protected string this[int index]
            {
                set { }
            }
        }
    }
}
