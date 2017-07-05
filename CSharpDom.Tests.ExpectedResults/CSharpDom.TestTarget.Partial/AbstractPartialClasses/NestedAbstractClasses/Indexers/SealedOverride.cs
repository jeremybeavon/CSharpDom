namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithSealedOverrideIndexer
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
