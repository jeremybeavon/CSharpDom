namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Indexers
{
    public abstract class AbstractClassWithNestedAbstractClassWithSealedOverrideIndexer
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
