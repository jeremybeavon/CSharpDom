namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Indexers
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNewIndexer
    {
        public abstract class Class : BaseClassWithIndexer
        {
            public new string this[int index]
            {
                set { }
            }
        }
    }
}
