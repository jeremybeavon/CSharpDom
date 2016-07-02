namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Indexers
{
    public struct StructWithNestedAbstractClassWithSealedOverrideIndexer
    {
        public abstract class Class : BaseClassWithIndexer
        {
            public sealed override string this[int index]
            {
                set { }
            }
        }
    }
}
