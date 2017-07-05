namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Indexers
{
    public partial class PartialClassWithNestedAbstractClassWithSealedOverrideIndexer
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
