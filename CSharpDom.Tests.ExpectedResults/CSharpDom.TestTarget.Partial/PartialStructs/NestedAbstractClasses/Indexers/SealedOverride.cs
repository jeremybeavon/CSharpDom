namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Indexers
{
    public partial struct PartialStructWithWithNestedAbstractClassWithSealedOverrideIndexer
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
