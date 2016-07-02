namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Indexers
{
    public struct StructWithNestedSealedClassWithNewIndexer
    {
        public sealed class Class : BaseClassWithIndexer
        {
            public new string this[int index]
            {
                set { }
            }
        }
    }
}
