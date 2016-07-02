namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Indexers
{
    public abstract class AbstractClassWithNestedAbstractClassWithOverrideIndexer
    {
        public abstract class Class : BaseClassWithIndexer
        {
            public override string this[int index]
            {
                set { }
            }
        }
    }
}
