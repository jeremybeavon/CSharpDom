namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Indexers
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithOverrideIndexer
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
