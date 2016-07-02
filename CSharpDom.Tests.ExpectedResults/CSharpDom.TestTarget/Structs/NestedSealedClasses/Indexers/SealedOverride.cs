namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Indexers
{
    public struct StructWithNestedSealedClassWithSealedOverrideIndexer
    {
        public sealed class Class : BaseClassWithIndexer
        {
            public sealed override string this[int index]
            {
                set { }
            }
        }
    }
}
